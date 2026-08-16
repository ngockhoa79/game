# 05 — Unity Editor Debugging

## Required Unity version

Use **Unity 2022.3.62f2** for baseline verification.

## First-run procedure

1. Open the repository root as a Unity project.
2. Confirm the editor version before allowing project conversion.
3. Wait for package import and C# compilation.
4. Capture the first clean Console state.
5. Record compile errors separately from runtime warnings.
6. Open `Stage1_Login`.
7. Enter Play Mode.
8. Follow the enabled runtime flow.
9. Record the first failure, not only the final symptom.

## Scene checkpoints

```text
[ ] Stage1_Login loads
[ ] Stage1 initialization completes
[ ] Transition to Stage2_Main
[ ] Main/Lobby initializes
[ ] NPCs initialize
[ ] Hero pipeline initializes
[ ] Resource loading succeeds
[ ] Battle transition starts
[ ] Stage3_Battle loads
[ ] Battle engine initializes
[ ] Battle loop executes
[ ] Battle result/exit works
```

## Existing diagnostics

`Assets/Editor` contains tracer/test/observer scripts including:

- `EVT08_Execution_Tracer`
- `Phase10PlayModeTest`
- `Phase14_3_Tracer`
- `Phase14_4_Observer`
- `Phase19_Stage2_Tracer`
- `Phase20_MainScene_Tracer`
- `Phase21_RealLobby_Tracer`
- `Phase22_Resource_Tracer`
- `Phase23_Resource_Tracer`
- `Phase24_RealHeroPipeline_Tracer`
- `Phase25_LobbySystem_Tracer`
- `Phase26_BattleTransition_Tracer`
- `Phase27_BattleEngine_Tracer`
- `Phase28_EndToEndLoop_Tracer`
- `Phase29_Persistence_Tracer`
- `Phase65_Baseline_Tracer`
- `Phase66A_Clean_Tracer`
- `Phase68B_Tracer`
- `Phase68D_Tracer`
- `PlayMakerFsmDiagnostic`

These are existing project tools. Do not delete/modify them during baseline unless required.

## Debugging a feature

Always identify the runtime object first:

```text
Scene
  -> GameObject
    -> Component
      -> Script
        -> Method
          -> State/Event
            -> Asset/Resource
```

## C# debugging

Use Visual Studio/Rider/VS Code debugger attached to Unity where supported. Place breakpoints at the first meaningful state transition rather than only at the final rendering method.

## PlayMaker debugging

Do not assume a missing behavior is a C# bug. Inspect:

- FSM owner GameObject
- FSM name
- current state
- transitions/events
- action parameters
- referenced Unity objects

`PlayMakerFsmDiagnostic.cs` exists specifically as an investigation aid.

## Asset debugging

When a component has a null/missing reference, inspect the serialized object in Inspector before changing code. A runtime symptom may be caused by a scene/prefab reference rather than implementation logic.

## Baseline evidence format

For each runtime test record:

```text
Scene:
GameObject:
Component:
Script:
Method/State:
Expected:
Actual:
Console error/warning:
Asset/reference involved:
Repro steps:
```
