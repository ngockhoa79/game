# 08 — OpenCode / AI Agent Guide

## Mission

Understand the existing Unity system before making changes. Prefer small, traceable changes over broad refactors.

## Source of truth

1. Actual source code and serialized Unity scene/prefab data.
2. Unity Editor runtime behavior.
3. Dependency graph (GitNexus when available).
4. These docs as a navigation/index layer.

If docs conflict with code/runtime, update the docs; do not force code to match an assumption in docs.

## Before changing code

For a requested feature/bug:

```text
Ticket / symptom
   ↓
Feature
   ↓
Scene
   ↓
GameObject
   ↓
Component
   ↓
Script/class
   ↓
Method/state/event
   ↓
Asset/resource
   ↓
Dependencies / impact
```

## Do not assume

- A scene filename proves its runtime entry point.
- A C# class is the only implementation.
- A missing visual means the renderer code is wrong.
- A state bug is necessarily a C# state-machine bug.
- A prefab is independent of its scene references.
- A resource folder is automatically loaded at runtime.

## Unity-specific checks

Before editing a serialized field or object relationship, inspect the corresponding Unity object/prefab/scene reference. Unity YAML can encode important dependencies that do not appear as C# imports.

For PlayMaker behavior, inspect the FSM and actions.

For character issues, inspect C#, Animator/Spine state, prefab references and required textures/materials together.

## Change scope

Do not refactor unrelated code while fixing a ticket unless the dependency analysis proves it is required.

For high-impact changes, document:

- affected files
- affected scenes
- affected GameObjects/components
- affected assets
- dependency impact
- runtime verification steps

## Verification

Every change should have a concrete Unity Editor verification path.

Example:

```text
Change: Battle transition

Open: Stage2_Main
Trigger: start battle
Observe: transition event
Verify: Stage3_Battle loads
Verify: battle state initialized
Check: Console has no new errors
```

## Documentation maintenance

When a previously unverified relationship is confirmed, update the relevant baseline document. Keep the docs concise and split by responsibility; do not create one giant architecture file.
