# Game System Baseline

> Baseline branch: `docs/system-baseline`  
> Source baseline: `main`  
> Unity: **2022.3.62f2**

## Purpose

This directory documents the existing Unity project before any functional update. The goal is to give developers and coding agents (including OpenCode) a compact, navigable model of the system instead of requiring them to rediscover the architecture from the entire repository.

## Documents

- `01-project.md` — Unity version, packages, build/runtime configuration.
- `02-folder-map.md` — repository folders grouped by technical role and asset type.
- `03-scene-flow.md` — scene/build flow and responsibilities of Stage scenes.
- `04-functional-map.md` — feature-oriented system map: Login, Lobby, NPC, Hero, Battle, etc.
- `05-debugging.md` — Unity Editor debugging workflow and existing tracing/diagnostic tools.
- `06-impact-analysis.md` — preliminary impact/risk model and GitNexus status.
- `07-known-issues.md` — currently known issues, unknowns, and baseline gaps.
- `08-agent-guide.md` — instructions for OpenCode/AI agents working on this repository.

## Important baseline rule

No production behavior is intentionally changed by this documentation branch. These documents describe what has been observed from repository structure/configuration. Items marked **UNVERIFIED** must be confirmed by source/runtime inspection before being treated as fact.

## Current runtime flow

```text
Stage1_Login
    -> Stage2_Main
        -> Stage3_Battle
        -> Stage4_Guidance
        -> Stage5_BattleShow
```

`Start` and `Stage0_Temp` are currently disabled in Build Settings.

## Next baseline phase

1. Open the project with Unity 2022.3.62f2.
2. Let package import and script compilation finish.
3. Record Console errors/warnings.
4. Run the enabled build flow from `Stage1_Login`.
5. Trace Stage1 -> Stage2 -> Battle using the existing Editor diagnostics.
6. Expand this documentation with verified class/method/asset relationships.
7. Run GitNexus locally and merge verified dependency/impact data into `06-impact-analysis.md`.
