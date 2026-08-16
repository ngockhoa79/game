# Login Runtime Baseline and Local Mock

## Runtime baseline

`Stage1_Login` successfully loads and enters runtime in Unity `2022.3.62f2`.

Observed initialization:

```text
NetManager singleton -> Awake
GlobalManager -> Awake
LoginFsmStep2Manager -> Awake
LoginFsmStep2Manager -> OnEnable
LoginFsmStep2Manager -> PrepareLoginView
LoginFsm -> Awake
```

## Blocking runtime issue without BE

The client attempts:

```text
host = 127.0.0.1
port = 16000
```

and receives Windows TCP `connection refused`.

This means the Unity client is behaving as a TCP client and no server is listening on the configured local endpoint. This is not currently classified as a `NetManager` bug.

## Observed login protocol flow

From `NetManager`:

```text
Msg 3: LoginByAuthTokenReq
        |
        v
Msg 2: LoginByAuthTokenAck
        |
        v
Msg 4: LoginBySessionTokenReq
        |
        v
Msg 1: LoginBySessionTokenAck
        |
        v
E_OnLoginSuccess
```

The first ACK provides a session token. The second ACK with an OK result triggers the login-success event.

## Local mock

A development-only TCP mock is provided at:

```text
Tools/MockServer/mock_login_server.py
Tools/MockServer/run_mock_server.bat
Tools/MockServer/README.md
```

Default endpoint:

```text
127.0.0.1:16000
```

Default flow:

```text
3 -> 2 -> 4 -> 1
```

The mock does not bypass the Unity login FSM. It keeps the real `NetManager` socket path and responds at the TCP boundary.

## Protocol assumptions that still require verification

The protocol message classes are provided by an external compiled protocol assembly and were not available as searchable source in the repository. The mock therefore emits the minimal protobuf wire representation expected from the observed ACK semantics:

- `LoginByAuthTokenAck`: result field 1 = `0`, session token field 2
- `LoginBySessionTokenAck`: result field 1 = `0`

The mock also auto-detects little/big-endian packet headers from incoming message ids, but defaults replies to the detected byte order.

Packet length semantics default to `messageId + payload` (`body` mode). The server supports `--length-mode payload` if the actual client framing proves to use payload-only length.

## Validation procedure

1. Stop Unity Play Mode.
2. Start `Tools/MockServer/run_mock_server.bat`.
3. Confirm it prints `Listening: 127.0.0.1:16000`.
4. Start `Stage1_Login` in Unity.
5. Observe the mock server log for `3 -> 2 -> 4 -> 1`.
6. Observe Unity Console for the real login-success path.
7. If the client rejects the response, capture the mock server's received payload hex and Unity's packet/login error; do not change `NetManager` until framing/schema is verified.

## Scope

The mock currently covers login only. It does not fabricate `S2CEnterGameAllInfoNtf` / player state or later game services. Those should be added only after the login handshake is confirmed against the actual protocol assembly.
