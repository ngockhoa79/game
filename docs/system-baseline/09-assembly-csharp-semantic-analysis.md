# 09 — Assembly-CSharp Semantic Analysis

## Scope

This document records direct source inspection of semantic C# files under `Assets/Scripts/Assembly-CSharp/`. It is intentionally separate from the folder map because filename grouping alone is not enough for this project.

## Major observation: mixed implementation state

The inspected source contains a mixture of:

1. Real executable implementation.
2. Partial implementation.
3. Methods whose bodies are empty.
4. Properties returning default/null values.

Examples:

- `BattleManager.Start()` initializes multiple runtime collections and `RegisterBattleHero()` has real logic.
- `BattleLineManager` has working dictionary/line operations.
- `SkillCtrller.InitSkill()` and `GetHitResult()` contain real logic.
- `Activity`, `ActivityChapter`, and `ActivityLevel` contain many empty/default-returning methods/properties.
- `ActivateEmbeddedNPC`, `ActivateEmbeddedArenaNPC`, and `ActivateEmbeddedShopNPC` expose PlayMaker actions but their `OnEnter()` bodies are empty.
- `AbstractAnimator` contains a full API shape but its inspected implementation methods are empty/default-returning.

This is a **critical baseline finding**. It must be verified in Unity before assuming these are intentionally stubbed, generated/decompiled placeholders, or an incomplete source snapshot.

## Semantic groups identified

### Battle runtime

Core classes inspected:

- `BattleManager`
- `BattleLineManager`
- `BattleHeroInfo`
- `SkillCtrller`

See `10-battle-system.md`.

### Activity system

Core classes inspected:

- `Activity`
- `ActivityChapter`
- `ActivityLevel`

See `11-activity-npc.md`.

### Lobby/NPC PlayMaker actions

Core classes inspected:

- `ActivateEmbeddedNPC`
- `ActivateEmbeddedArenaNPC`
- `ActivateEmbeddedShopNPC`

See `11-activity-npc.md`.

### Animation infrastructure

Core classes inspected:

- `AbstractAnimator`
- `ActiveAnimation`

These are cross-feature infrastructure and therefore potentially high impact.

### Ads/integration

`AdsManager` inherits from `MonoSingletonTemplate<AdsManager>` and exposes `HasSDK`. Initialization is empty in the inspected source. Exact SDK dependency is not yet traced.

## Architecture pattern observed

The source uses several Unity-specific patterns:

```text
MonoBehaviour
  + static Instance / FindObjectOfType singleton
  + serialized GameObject references
  + runtime dictionaries/sets
  + PlayMaker FSM actions
  + protocol/config DTOs
  + animation systems
```

There is no evidence yet that the project follows a single modern architectural pattern such as MVC/MVVM/ECS. Treat it as a hybrid legacy Unity architecture.

## Dependency boundaries

Observed namespaces indicate important external/internal boundaries:

- `HutongGames.PlayMaker` → FSM execution.
- `Ice.ProjectCos.Protocol` → battle/activity network/protocol DTOs.
- `Ice.ProjectCos.Config` / `ConfigGenerator.Template` → configuration templates.
- `Ice.ProjectCos.UI.DataModel` → UI/data integration.
- `UnityEngine` → scene/object lifecycle.
- `AnimationOrTween` → UI/animation infrastructure.

## Agent guidance

When an issue touches one of these classes, inspect the implementation body rather than relying on method names. In this repository, a method can exist as a complete API surface while currently doing nothing.
