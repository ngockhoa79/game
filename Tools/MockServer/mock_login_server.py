#!/usr/bin/env python3
"""Minimal TCP mock for the game's login protocol.

Observed Unity framing:
  [4-byte totalLength][4-byte messageId][protobuf payload]

Unity diagnostics showed LoginByAuthTokenReq with totalLength=30 and
payloadBytes=22, proving totalLength includes the 8-byte framing header.
"""

from __future__ import annotations

import argparse
import socket
import struct
import threading
from typing import Tuple

HOST = "127.0.0.1"
PORT = 16000
AUTH_REQ = 3
AUTH_ACK = 2
SESSION_REQ = 4
SESSION_ACK = 1
RESULT_OK = 0
SESSION_TOKEN = "mock-session-900001"
HEADER_SIZE = 8
MAX_PACKET_SIZE = 16 * 1024 * 1024


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
    return proto_int32(1, RESULT_OK) + proto_string(2, session_token)


def session_ack_payload() -> bytes:
    return proto_int32(1, RESULT_OK)


def detect_byte_order(header: bytes) -> Tuple[str, int, int]:
    for order in ("<", ">"):
        total_length = struct.unpack(order + "i", header[:4])[0]
        message_id = struct.unpack(order + "i", header[4:8])[0]
        if message_id in (AUTH_REQ, SESSION_REQ):
            return order, total_length, message_id

    order = "<"
    return order, struct.unpack(order + "i", header[:4])[0], struct.unpack(order + "i", header[4:8])[0]


def build_packet(message_id: int, payload: bytes, byte_order: str) -> bytes:
    total_length = HEADER_SIZE + len(payload)
    return (
        struct.pack(byte_order + "i", total_length)
        + struct.pack(byte_order + "i", message_id)
        + payload
    )


def parse_frame(conn: socket.socket) -> Tuple[str, int, bytes]:
    header = read_exact(conn, HEADER_SIZE)
    byte_order, total_length, message_id = detect_byte_order(header)

    if total_length < HEADER_SIZE or total_length > MAX_PACKET_SIZE:
        raise ValueError(
            f"invalid totalLength={total_length}, messageId={message_id}, header={header.hex()}"
        )

    # totalLength includes [length:int32][messageId:int32][payload].
    payload_size = total_length - HEADER_SIZE
    payload = read_exact(conn, payload_size)
    return byte_order, message_id, payload


def handle_client(conn: socket.socket, addr, args) -> None:
    print(f"[MOCK] client connected: {addr}")
    conn.settimeout(60)

    try:
        while True:
            byte_order, message_id, payload = parse_frame(conn)
            print(
                f"[MOCK] <- msg={message_id} total={HEADER_SIZE + len(payload)} "
                f"payload={len(payload)} bytes hex={payload.hex()}"
            )

            if message_id == AUTH_REQ:
                response = build_packet(
                    AUTH_ACK,
                    auth_ack_payload(args.session_token),
                    byte_order,
                )
                conn.sendall(response)
                print(
                    f"[MOCK] -> msg={AUTH_ACK} total={len(response)} "
                    f"result=OK sessionToken={args.session_token!r}"
                )

            elif message_id == SESSION_REQ:
                response = build_packet(
                    SESSION_ACK,
                    session_ack_payload(),
                    byte_order,
                )
                conn.sendall(response)
                print(f"[MOCK] -> msg={SESSION_ACK} total={len(response)} result=OK (login success)")
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
    parser.add_argument("--close-after-login", action="store_true")
    args = parser.parse_args()

    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    server.bind((args.host, args.port))
    server.listen(16)

    print("=" * 64)
    print("GAME LOGIN MOCK SERVER")
    print(f"Listening: {args.host}:{args.port}")
    print("Observed framing: [totalLength][messageId][protobuf payload]")
    print("Flow: 3 -> 2 -> 4 -> 1")
    print(f"Session token: {args.session_token}")
    print("Press Ctrl+C to stop.")
    print("=" * 64)

    try:
        while True:
            conn, addr = server.accept()
            threading.Thread(target=handle_client, args=(conn, addr, args), daemon=True).start()
    except KeyboardInterrupt:
        print("\n[MOCK] shutting down")
    finally:
        server.close()


if __name__ == "__main__":
    main()
