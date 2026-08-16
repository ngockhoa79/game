# 02 — Folder Map

## Goal

Group repository content by technical responsibility so an agent can locate implementation, scene, and asset files without treating every folder as a feature.

## Major groups

### Runtime / gameplay code

- `Assets/Scripts/`
- `Assets/Scripts/Assembly-CSharp/`

This is the primary C# implementation area. It contains both semantic classes (`Activity`, `AdsManager`, `ActivateEmbeddedNPC`, etc.) and many classes whose names are not self-describing. Filename-only analysis is therefore insufficient.

### Scenes

- `Assets/__Scene/GameScene/`
- Stage scenes: Login, Main, Battle, Guidance, BattleShow.

Scenes are serialized dependency hubs: GameObjects, MonoBehaviours, serialized references, UI and runtime composition may be embedded in the scene YAML.

### Asset categories

The `Assets` tree contains separate categories including:

- `AnimationClip`
- `AudioClip`
- `Font`
- `GameObject`
- `Material`
- `Mesh`
- `Shader`
- `Sprite`
- `Texture2D`
- `TextAsset`

Treat these as implementation dependencies rather than isolated art folders. A gameplay component may depend on one or more of these through serialized Unity references.

### Resource/loading areas

Observed resource-oriented areas include:

- `Resources`
- `resource`
- `StreamingAssets`
- `__artres`
- `igsoft_resources`
- `music`

**UNVERIFIED:** exact loading ownership and whether each folder participates in runtime loading must be confirmed from code.

### Animation / character runtime

- `newspine`
- Spine-related settings/assets
- animation clips and related assets

Spine is likely relevant to Hero/character presentation, but exact feature ownership is **UNVERIFIED** until references are traced.

### FSM / visual logic

- `playmaker`
- `PlayMakerFsmDiagnostic.cs`

PlayMaker appears to be a meaningful part of runtime behavior. Do not assume all game logic is inside C# methods.

### Editor / diagnostics

`Assets/Editor` contains a substantial set of tracer/observer/test scripts. See `05-debugging.md`.

### Plugins

- `Assets/Plugins`

Third-party/native integrations must be treated as external dependency boundaries during impact analysis.

## Agent rule

When changing a feature, inspect all four layers:

```text
C# code
  + Scene/GameObject references
  + FSM/PlayMaker state
  + Asset/Resource references
```

A code-only change is not considered fully analyzed for Unity features.
