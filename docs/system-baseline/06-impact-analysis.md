# 06 — Impact Analysis

## Status

**Pre-GitNexus baseline.** The impact levels in this document are architectural hypotheses derived from scene/build configuration, source naming and existing tracer coverage. They are not a substitute for a dependency graph.

## Impact levels

- **CRITICAL** — likely cross-feature/core runtime dependency. Small changes can prevent the game from running or break multiple systems.
- **VERY HIGH** — shared gameplay/scene pipeline.
- **HIGH** — feature entry point or shared state/resource.
- **MEDIUM** — isolated feature with limited known coupling.
- **LOW** — tooling/content with limited runtime reach.

## Preliminary impact map

| System | Impact | Reason |
|---|---|---|
| Resource loading | CRITICAL | Cross-feature asset/data dependency |
| Battle engine | CRITICAL | Core runtime gameplay |
| Main/Lobby | VERY HIGH | Multiple systems converge in Stage2 |
| Hero pipeline | VERY HIGH | Character state/assets likely reused |
| Battle transition | VERY HIGH | Cross-scene state boundary |
| Persistence | HIGH | Cross-session/shared state |
| Login | HIGH | Gateway to runtime |
| NPC | HIGH | Entry points into other features |
| Battle presentation | HIGH | Shared character/animation assets |
| Activity | MEDIUM/HIGH | Feature content; shared dependencies unknown |
| Shop | MEDIUM/HIGH | Entry through lobby/NPC |
| Guidance | MEDIUM | Separate scene; coupling unknown |
| Editor diagnostics | LOW runtime / HIGH debugging value | Tooling rather than gameplay |

## GitNexus

GitNexus has **not** been run against this repository in the current environment. Therefore this document must not claim caller/callee counts or exact blast radius.

Once GitNexus is available locally, analyze the repository and update this document with:

- symbol-level callers/callees
- dependency paths
- process/cluster relationships
- impact/blast-radius results
- changed-file impact checks before edits

## Recommended local analysis

```bash
git clone https://github.com/ngockhoa79/game.git
cd game
npx gitnexus analyze
```

If using a Unity-specific GitNexus integration, follow that tool's documented Unity parser workflow instead of inventing parser arguments.

## Change safety rule

Before modifying a high-impact file, answer:

1. Who calls it?
2. What does it call?
3. Which scene(s) reference it?
4. Which prefab/GameObject references it?
5. Which FSM state/event references it?
6. Which assets/resources does it load?
7. Which features share the same state/manager?
8. What runtime checkpoint will prove the change is safe?
