# 03 — Scene and Runtime Flow

## Build order currently enabled

```text
Stage1_Login
    -> Stage2_Main
        -> Stage3_Battle
        -> Stage4_Guidance
        -> Stage5_BattleShow
```

The Build Settings also contain `Start` and `Stage0_Temp`, but both are disabled.

## Stage1_Login

**Purpose:** Login/initialization stage.

**Logic:** C# + scene composition + possible FSM/resource initialization.

**Asset layer:** UI, scene references and resource dependencies.

**Impact:** HIGH because failure here can prevent the rest of the game flow.

**Verified:** scene exists and is enabled in Build Settings.

**UNVERIFIED:** exact login classes, network/authentication behavior, and transition method.

## Stage2_Main

**Purpose:** Main game/lobby area.

Expected feature clusters based on source naming and existing tracer coverage:

- Lobby
- NPC
- Hero
- Activity
- Shop
- Main navigation
- Resource loading

**Impact:** VERY HIGH because multiple systems converge here.

Existing diagnostics include `Phase19_Stage2_Tracer`, `Phase20_MainScene_Tracer`, `Phase21_RealLobby_Tracer`, `Phase25_LobbySystem_Tracer`.

## Stage3_Battle

**Purpose:** Battle runtime.

Expected clusters:

- Battle engine/state
- Character/Hero runtime
- Animation/effects
- FSM
- Result/end-of-battle

Existing diagnostic coverage includes `Phase26_BattleTransition_Tracer`, `Phase27_BattleEngine_Tracer`, and `Phase28_EndToEndLoop_Tracer`.

**Impact:** CRITICAL.

## Stage4_Guidance

**Purpose:** Guidance/tutorial presentation.

**Impact:** MEDIUM until dependencies are verified.

## Stage5_BattleShow

**Purpose:** Battle presentation/showcase/replay-like flow.

**Impact:** HIGH if it shares battle runtime or character assets.

## Runtime tracing model

The project already has tracer names suggesting this historical workflow:

```text
Stage2
 -> MainScene
 -> RealLobby
 -> Resource
 -> RealHeroPipeline
 -> LobbySystem
 -> BattleTransition
 -> BattleEngine
 -> EndToEndLoop
 -> Persistence
```

This is a useful investigation hypothesis, not yet a complete verified call graph.

## Unity Editor baseline run

The first runtime test should start from the enabled flow, record Console output, and verify each transition before any source modification.
