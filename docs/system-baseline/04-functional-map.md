# 04 — Functional Map

This document is intentionally feature-oriented. Each feature should eventually contain: purpose, entry point, files, logic, state, assets, scenes, dependencies, impact and Unity debug procedure.

## Login

**Purpose:** enter/initialize the game.

**Scene:** `Stage1_Login`.

**Likely layers:** scene + C# + resource initialization.

**Logic location:** NOT YET VERIFIED.

**Assets:** scene/UI/resource references; exact assets NOT YET VERIFIED.

**Impact:** HIGH.

## Lobby / Main

**Purpose:** primary game/main area.

**Scene:** `Stage2_Main`.

**Likely components:** main navigation, NPCs, Hero, activities, shop and resource loading.

**Existing debug evidence:** Stage2/MainScene/RealLobby/LobbySystem tracers.

**Logic location:** distributed between C#, Scene references and potentially PlayMaker FSM.

**Impact:** VERY HIGH.

## NPC

**Observed semantic classes include:**

- `ActivateEmbeddedNPC`
- `ActivateEmbeddedArenaNPC`
- `ActivateEmbeddedShopNPC`

**Purpose:** activate or configure embedded NPC functionality in the main/lobby scene.

**Logic:** these classes are concrete evidence of NPC-related runtime logic; exact call graph is NOT YET VERIFIED.

**Assets:** likely GameObject/Prefab/scene references; exact asset mapping NOT YET VERIFIED.

**Impact:** HIGH because NPCs can be entry points into Arena/Shop/game systems.

## Hero / Character Pipeline

**Purpose:** load, create, configure and present hero/character entities.

**Observed evidence:** `Phase24_RealHeroPipeline_Tracer` and character/animation-related asset groups.

**Logic:** C# + animation/Spine + scene/object references; exact pipeline NOT YET VERIFIED.

**Assets:** likely Spine, Sprite, AnimationClip, Material and GameObject assets.

**Impact:** VERY HIGH due to likely reuse across Lobby and Battle.

## Activity

**Observed semantic classes include:**

- `Activity`
- `ActivityChapter`
- `ActivityDayRecharge`
- `ActivityLevel`

**Purpose:** activity/event-related game content.

**Scene:** likely Main/Lobby or feature-specific UI.

**Logic:** C# classes are confirmed; ownership and UI entry points NOT YET VERIFIED.

**Impact:** MEDIUM/HIGH depending on shared managers/resources.

## Shop

**Observed evidence:** `ActivateEmbeddedShopNPC` and shop-oriented source naming.

**Purpose:** shop entry/access.

**Logic:** C# + NPC activation + UI/FSM/resource layers are possible.

**Impact:** MEDIUM/HIGH.

## Battle Transition

**Purpose:** move from Main/Lobby into Battle and initialize the battle scene/state.

**Scenes:** `Stage2_Main` -> `Stage3_Battle`.

**Debug evidence:** `Phase26_BattleTransition_Tracer`.

**Impact:** VERY HIGH.

## Battle Engine

**Purpose:** execute battle state/logic.

**Scene:** `Stage3_Battle`.

**Debug evidence:** `Phase27_BattleEngine_Tracer`.

**Likely layers:** C# gameplay logic + FSM + character/animation/effect assets.

**Impact:** CRITICAL.

## Battle Presentation

**Scenes:** `Stage3_Battle`, `Stage5_BattleShow`.

**Likely assets:** AnimationClip, Spine, Sprite, Material, AudioClip, effects.

**Impact:** HIGH.

## Guidance

**Scene:** `Stage4_Guidance`.

**Purpose:** guidance/tutorial flow.

**Logic/assets:** NOT YET VERIFIED.

**Impact:** MEDIUM.

## Persistence

**Purpose:** retain state between flows/sessions.

**Evidence:** `Phase29_Persistence_Tracer`.

**Exact storage mechanism:** NOT YET VERIFIED.

**Impact:** HIGH because persistence can affect many features indirectly.

## Resource Loading

**Observed resource areas:** `Resources`, `resource`, `StreamingAssets`, `__artres`, `igsoft_resources`, `music`.

**Purpose:** runtime asset/data loading.

**Evidence:** `Phase22_Resource_Tracer`, `Phase23_Resource_Tracer`.

**Impact:** CRITICAL because resource loading is a cross-feature dependency.

## Cross-cutting rule

For every future issue, identify:

```text
Feature
 -> Scene
 -> GameObject
 -> Component
 -> C# method/class
 -> FSM state/event
 -> Resource/Asset
 -> Caller/Callee impact
```
