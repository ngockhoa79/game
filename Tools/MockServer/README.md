# Local Login Mock Server

This is a development-only TCP mock for running `Stage1_Login` before the real BE server is available.

## Why this exists

The Unity client currently attempts to connect to:

```text
127.0.0.1:16000
```

The login flow observed in `NetManager` is:

```text
Client                         Mock
  |                             |
  |--- Msg 3: AuthTokenReq --->|
  |<-- Msg 2: AuthTokenAck ----|
  |                             |
  |--- Msg 4: SessionReq ------>|
  |<-- Msg 1: SessionAck -------|
  |                             |
  |        Login success        |
```

The mock returns result enum value `0` (OK) and a deterministic session token.

## Run

From the repository root:

```bash
python Tools/MockServer/mock_login_server.py
```

Expected output:

```text
GAME LOGIN MOCK SERVER
Listening: 127.0.0.1:16000
Flow: 3 -> 2 -> 4 -> 1
```

Then start Unity and enter Play Mode on `Stage1_Login`.

The server prints every received message id and payload hex so the wire protocol can be verified against the real backend later.

## Options

```bash
python Tools/MockServer/mock_login_server.py --session-token mock-session-900001
```

If packet framing is later confirmed to use the payload-only length instead of `messageId + payload`:

```bash
python Tools/MockServer/mock_login_server.py --length-mode payload
```

## Protocol assumptions

The game's protocol types are supplied by an external compiled protocol assembly, so the mock intentionally does not duplicate the generated C# classes. It only emits the minimal protobuf wire fields required by the observed login acknowledgements:

- `LoginByAuthTokenAck`: field 1 `result = 0`, field 2 `sessionToken`
- `LoginBySessionTokenAck`: field 1 `result = 0`

These field numbers and the packet framing should be verified against the actual protocol assembly/source before treating the mock as a production-equivalent backend.

## Scope

This mock is for Editor/development testing only. It is not a replacement for the real login/game server and currently does not implement player state, hero data, formation data, activity data, battle state, or other game messages.
