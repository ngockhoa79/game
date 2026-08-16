# 07 — Known Issues / Baseline Gaps

## Important distinction

At this point there are **no newly confirmed runtime bugs** from our own Unity execution because the project has not yet been launched in Unity Editor in this workflow.

The following are baseline gaps/risks, not confirmed gameplay defects.

## Gap 1 — No runtime verification yet

We have not yet confirmed:

- whether the project opens cleanly in Unity 2022.3.62f2
- whether packages resolve cleanly
- whether C# compilation is clean
- whether Stage1_Login starts successfully
- whether transitions between stages work

## Gap 2 — Exact C# architecture is not fully mapped

`Assembly-CSharp` contains many files, including both semantic and non-semantic names. A filename-level map is insufficient.

Required next step: inspect class inheritance, methods, serialized references, events and cross-file calls.

## Gap 3 — Scene-to-script mapping is not complete

The Build Settings establish the major scenes, but the exact GameObject/component hierarchy and which scripts are attached to which objects must be verified from scene YAML/Unity Inspector.

## Gap 4 — FSM ownership is not complete

PlayMaker is present and diagnostics exist. Exact FSM states/events/actions involved in Login, Lobby and Battle are not yet mapped.

## Gap 5 — Asset ownership is not complete

Asset folders are known, but exact feature -> prefab -> sprite/texture/animation/audio/resource mappings are not yet fully verified.

## Gap 6 — Dependency impact is not GitNexus-verified

No exact caller/callee or blast-radius graph has been captured yet.

## Current working hypotheses

These should be treated as hypotheses until runtime/source tracing confirms them:

- Stage2_Main is the main integration/lobby hub.
- Hero/character pipeline is shared by Lobby and Battle.
- Resource loading is a cross-feature dependency.
- PlayMaker contributes meaningful runtime logic.
- Battle transition is a critical boundary between Stage2 and Stage3.

## Baseline bug policy

When the first Unity run reveals issues, append them here with:

- symptom
- first failing scene
- first failing GameObject/component
- Console message
- stack trace/FSM state
- suspected root cause
- confirmed root cause
- reproduction steps
- fix status
