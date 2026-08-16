# 11 — Activity and NPC Systems

## Activity

### Activity

`Activity` is a plain C# state/container object, not a MonoBehaviour.

Observed state:

- `List<ActivityChapter> mChapters`
- open-position string
- `Dictionary<int, List<ActivityLevel>> mMaping`
- notification key `LastNotifyExploreDayOfYear`

Observed responsibilities:

- Receive quest/activity status from `ActivityQuestProto`.
- Create chapter/level mappings.
- Load all activity chapters.
- Generate open-position state.
- Check for newly opened activity.
- Notify activity opening.
- Notify guild-build opening.

**Implementation status:** most/all methods in the inspected source are empty/default. This must be verified before relying on Activity runtime behavior.

### ActivityChapter

`ActivityChapter` wraps `ActivityChapterTemplateExt` configuration.

State includes:

- chapter ID
- current level/index
- level list
- display/opening names/hints
- position/background/enemy header
- experience/award settings
- challenge limits and usage
- energy cost
- enable/disable timestamps
- days-of-week schedule
- open/close hours/minutes
- next open/close times

Observed decisions:

- challenge time available
- chapter opened/not closed
- day-of-week availability
- normal/hard/acheron level availability
- next-level activation
- chapter schedule availability
- chapter enable state

The constructor and decision methods are currently empty/default in the inspected source.

### ActivityLevel

`ActivityLevel` wraps `ActivityDuplicateTemplate` and exposes:

- Level ID
- difficulty
- required open level
- index
- formation ID
- description
- drop rewards (`ThingHolding`)

Constructor and properties are currently default/empty in the inspected source.

## Activity dependency model

```text
Protocol: ActivityQuestProto
        ↓
Activity
        ↓
ActivityChapter
        ↓
ActivityLevel
        ↓
Config templates / rewards
        ↓
UI (ownership NOT VERIFIED)
```

## NPC / PlayMaker actions

### ActivateEmbeddedNPC

- Inherits `FsmStateAction`.
- Action category: `ConditionalJudgment`.
- Has `Presentation` flag.
- `OnEnter()` is currently empty.

### ActivateEmbeddedArenaNPC

Same structural pattern as `ActivateEmbeddedNPC`.

### ActivateEmbeddedShopNPC

- Inherits `FsmStateAction`.
- Has `Presentation` flag.
- `OnEnter()` is empty.
- Contains private `inactive(Intent i)` method.
- Imports `Ice.ProjectCos.UI.Intents`.

## Important architectural conclusion

NPC activation is not purely C# gameplay code. It is exposed as a PlayMaker action, meaning the actual runtime trigger is likely:

```text
Scene GameObject
   ↓
PlayMakerFSM
   ↓
ConditionalJudgment action
   ↓
ActivateEmbedded*NPC.OnEnter()
   ↓
NPC/UI intent
```

The FSM graph and serialized action parameters must be inspected in Unity to determine the real flow.

## Impact

- Activity: MEDIUM/HIGH depending on shared config/UI dependencies.
- Generic NPC activation: HIGH.
- Arena NPC activation: HIGH because it may bridge Lobby → Arena.
- Shop NPC activation: HIGH because it bridges Lobby → Shop/UI intent.

## Debug checkpoints

For NPC issues:

1. Open `Stage2_Main`.
2. Find the NPC GameObject.
3. Inspect `PlayMakerFSM`.
4. Identify the FSM containing the `ActivateEmbedded*NPC` action.
5. Check `Presentation`.
6. Step through `OnEnter()`.
7. Inspect the target NPC/GameObject state.
8. For Shop, inspect the `Intent` path.

For Activity issues:

1. Identify the activity entry UI.
2. Locate the object/class that owns `Activity`.
3. Verify protocol/config input.
4. Inspect chapter/level state.
5. Verify schedule calculations.
6. Verify reward/drop data.
