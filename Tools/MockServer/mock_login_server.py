#!/usr/bin/env python3
"""Minimal TCP mock for the game's login protocol.

The Unity client currently connects to 127.0.0.1:16000 and uses this flow:
  3 -> LoginByAuthTokenReq
  2 <- LoginByAuthTokenAck
  4 -> LoginBySessionTokenReq
  1 <- LoginBySessionTokenAck

The protocol classes are supplied by the game's external protocol assembly, so
this mock deliberately does not depend on generated protobuf classes. It
implements only the protobuf wire fields needed for the two ACK messages:
  LoginByAuthTokenAck: field 1 = result enum (0 = OK), field 2 = session token
  LoginBySessionTokenAck: field 1 = result enum (0 = OK)

The packet header is inferred from the first client packet. By default the
header is [int32 bodyLength][int32 messageId], little-endian, where bodyLength
is messageId(4) + protobuf payload. Use --byte-order/--length-mode if the
protocol implementation proves otherwise.
"""

from __future__ import annotations

import argparse
import socket
import struct
import threading
import time
from typing import Optional, Tuple


HOST = "127.0.0.1"
PORT = 16000
AUTH_REQ = 3
AUTH_ACK = 2
SESSION_REQ = 4
SESSION_ACK = 1
RESULT_OK = 0
SESSION_TOKEN = "mock-session-900001"


def read_exact(conn: socket.socket, size: int) -> bytes:
    data = bytearray()
    while len(data) < size:
        chunk = conn.recv(size - len(data))
        if not chunk:
            raise ConnectionError("client disconnected")
        data.extend(chunk)
    return bytes(data)


def encode_varint(value: int) -> bytes:
    out = bytearray()
    value = int(value)
    while value >= 0x80:
        out.append((value & 0x7F) | 0x80)
        value >>= 7
    out.append(value)
    return bytes(out)


def proto_int32(field: int, value: int) -> bytes:
    return encode_varint((field << 3) | 0) + encode_varint(value)


def proto_string(field: int, value: str) -> bytes:
    raw = value.encode("utf-8")
    return encode_varint((field << 3) | 2) + encode_varint(len(raw)) + raw


def auth_ack_payload(session_token: str) -> bytes:
    # result = OK (field 1), sessionToken (field 2)
    return proto_int32(1, RESULT_OK) + proto_string(2, session_token)


def session_ack_payload() -> bytes:
    # result = OK (field 1)
    return proto_int32(1, RESULT_OK)


def unpack_int(raw: bytes, byte_order: str) -> int:
    return struct.unpack(byte_order + "i", raw)[0]


def detect_header(header: bytes) -> Tuple[str, int, int]:
    """Return (byte_order, declared_length, message_id).

    We prefer a message id of 3 or 4. This makes the mock tolerant of a
    big/little-endian packet header without guessing from machine endianness.
    """
    candidates = []
    for order in ("<", ">"):
        length = unpack_int(header[:4], order)
        msg_id = unpack_int(header[4:8], order)
        if msg_id in (AUTH_REQ, SESSION_REQ):
            candidates.append((order, length, msg_id))
    if candidates:
        return candidates[0]
    order = "<"
    return order, unpack_int(header[:4], order), unpack_int(header[4:8], order)


def build_packet(message_id: int, payload: bytes, byte_order: str, length_mode: str) -> bytes:
    body = struct.pack(byte_order + "i", message_id) + payload
    if length_mode == "payload":
        length = len(payload)
    else:
        length = len(body)
    return struct.pack(byte_order + "i", length) + body


def parse_frame(conn: socket.socket) -> Tuple[str, int, bytes]:
    header = read_exact(conn, 8)
    byte_order, declared_length, message_id = detect_header(header)

    if declared_length < 4 or declared_length > 16 * 1024 * 1024:
        raise ValueError(
            f"invalid packet length={declared_length}, messageId={message_id}"
        )

    payload_size = declared_length - 4
    payload = read_exact(conn, payload_size)
    return byte_order, message_id, payload


def handle_client(conn: socket.socket, addr, args) -> None:
    print(f"[MOCK] client connected: {addr}")
    conn.settimeout(30)
    session_token = args.session_token
    try:
        while True:
            byte_order, message_id, payload = parse_frame(conn)
            print(
                f"[MOCK] <- msg={message_id} payload={len(payload)} bytes "
                f"hex={payload.hex()}"
            )

            if message_id == AUTH_REQ:
                response = build_packet(
                    AUTH_ACK,
                    auth_ack_payload(session_token),
                    byte_order,
                    args.length_mode,
                )
                conn.sendall(response)
                print(
                    f"[MOCK] -> msg={AUTH_ACK} result=OK "
                    f"sessionToken={session_token!r}"
                )

            elif message_id == SESSION_REQ:
                response = build_packet(
                    SESSION_ACK,
                    session_ack_payload(),
                    byte_order,
                    args.length_mode,
                )
                conn.sendall(response)
                print("[MOCK] -> msg=1 result=OK (login success)")
                if args.close_after_login:
                    return

            else:
                print(f"[MOCK] ignoring unsupported message id={message_id}")

    except (ConnectionError, TimeoutError, socket.timeout) as exc:
        print(f"[MOCK] client disconnected: {exc}")
    except Exception as exc:
        print(f"[MOCK] client error: {type(exc).__name__}: {exc}")
    finally:
        try:
            conn.close()
        except OSError:
            pass
        print(f"[MOCK] client closed: {addr}")


def main() -> None:
    parser = argparse.ArgumentParser(description="Unity game login TCP mock server")
    parser.add_argument("--host", default=HOST)
    parser.add_argument("--port", type=int, default=PORT)
    parser.add_argument("--session-token", default=SESSION_TOKEN)
    parser.add_argument(
        "--length-mode",
        choices=("body", "payload"),
        default="body",
        help="Meaning of the first int32 packet length. Default: body=msgId+payload.",
    )
    parser.add_argument(
        "--close-after-login",
        action="store_true",
        help="Close the client socket after LoginBySessionTokenAck.",
    )
    args = parser.parse_args()

    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    server.bind((args.host, args.port))
    server.listen(16)

    print("=" * 64)
    print("GAME LOGIN MOCK SERVER")
    print(f"Listening: {args.host}:{args.port}")
    print("Flow: 3 -> 2 -> 4 -> 1")
    print(f"Session token: {args.session_token}")
    print(f"Length mode: {args.length_mode}")
    print("Press Ctrl+C to stop.")
    print("=" * 64)

    try:
        while True:
            conn, addr = server.accept()
            threading.Thread(
                target=handle_client,
                args=(conn, addr, args),
                daemon=True,
            ).start()
    except KeyboardInterrupt:
        print("\n[MOCK] shutting down")
    finally:
        server.close()


if __name__ == "__main__":
    main()
