# 01 — Project Configuration

## Unity

- Editor version: **2022.3.62f2**
- Source: `ProjectSettings/ProjectVersion.txt`
- Do not upgrade Unity during baseline verification.

## Packages

`Packages/manifest.json` currently declares Unity modules plus:

- `com.unity.ai.navigation` `1.1.6`
- AI, animation, audio, asset bundle, cloth, director, physics, UI/UIElements, video, VR/XR and related Unity modules.

## Player configuration observations

From `ProjectSettings/ProjectSettings.asset`:

- Product name: `mi`
- Company name: `wbcdld`
- Default resolution: 1920x1080
- Landscape orientation is enabled.
- Run in background is enabled.
- Unity splash screen is enabled.

These values are configuration observations, not design assumptions.

## Build scenes

`ProjectSettings/EditorBuildSettings.asset` currently enables:

1. `Assets/__Scene/GameScene/Stage1_Login.unity`
2. `Assets/__Scene/GameScene/Stage2_Main.unity`
3. `Assets/__Scene/GameScene/Stage3_Battle.unity`
4. `Assets/__Scene/GameScene/Stage4_Guidance.unity`
5. `Assets/__Scene/GameScene/Stage5_BattleShow.unity`

Disabled:

- `Assets/__Scene/GameScene/Start.unity`
- `Assets/__Scene/GameScene/Stage0_Temp.unity`

## Baseline implication

The enabled build flow should be treated as the primary runtime path until Unity Editor testing proves otherwise. Do not assume `Start` is an entry point merely because the file exists.
