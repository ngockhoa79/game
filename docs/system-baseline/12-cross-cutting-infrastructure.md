# 12 — Cross-Cutting Infrastructure

## AbstractAnimator

`AbstractAnimator : MonoBehaviour` is a reusable animation state machine.

### State model

- STOP
- DELAY
- PLAY
- INTERVAL
- PINGPONG

### Configuration

- blending mode
- loop mode
- animation curve
- delay
- duration
- loop interval
- auto play

### Lifecycle

- `Start()`
- `Update()`
- `Animate()`
- interpolation through abstract `Interpolate(float)`
- finish/stop/reset
- editor context-menu helpers for grabbing initial/target state

### Events

- state changed
- disposable/on-finish

**Implementation warning:** inspected method bodies are empty/default. Verify whether this source is intended to be functional before depending on it.

## ActiveAnimation

`ActiveAnimation : MonoBehaviour` is NGUI/AnimationOrTween infrastructure.

It holds:

- animation callbacks
- receiver/callback method
- legacy `Animation`
- `Animator`
- clip/direction state

Static overloads allow playback from both `Animation` and `Animator`.

Because this is generic animation infrastructure, impact can be broad even when a bug appears to be UI-only.

## AdsManager

`AdsManager : MonoSingletonTemplate<AdsManager>` is an SDK integration boundary.

Observed:

- `HasSDK` flag
- `OnInit()` override

`OnInit()` is empty in inspected source.

Exact SDK/plugin ownership is not yet verified.

## Singleton pattern

Several inspected systems use:

```text
private static _instance
       ↓
Instance getter
       ↓
FindObjectOfType<T>()
```

This creates implicit scene dependencies. When debugging `null Instance`, check scene composition before changing code.

## Protocol/config coupling

The code frequently consumes `Ice.ProjectCos.*` types. This indicates the game runtime is strongly coupled to generated/config/protocol models.

When a property unexpectedly defaults/nulls, inspect:

1. source DTO
2. config template
3. constructor/mapping code
4. runtime owner
5. serialized scene object

## Cross-cutting impact rule

Changes to animation, singleton lifecycle, resource loading or protocol mapping should be considered HIGH impact until GitNexus/runtime verification proves otherwise.
