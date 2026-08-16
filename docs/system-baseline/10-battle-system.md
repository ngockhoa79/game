# 10 — Battle System Deep Dive

## Primary class

`BattleManager : MonoBehaviour`

### Responsibilities observed from API/state

- Own active battle hero records.
- Own support/story hero records.
- Track battle skills and buffs.
- Track fighter lock/death state.
- Coordinate `BattleLineManager`.
- Hold `BattleReport`.
- Connect to `UIBattle`.
- Own hero/skill/buff/effect root GameObjects.
- Coordinate `BattleCameraCtrller`.
- Manage story/cutin state.
- Process battle action protocol messages.
- Replay battle report.

### Runtime state

`BattleManager` maintains:

```text
battleHeroDic        fighterId -> BattleHeroInfo
supportHeroDic       fighterId -> BattleHeroInfo
storyHerosDic        fighterId -> BattleHeroInfo
battleSkillDic       GameObject -> BattleSkillInfo
battleBuffDic        buffId -> BattleBuffInfo
lockFighterSet       fighter IDs currently locked
waitDieList          pending deaths
 deadAlreadySet      fighters already processed as dead
loseSideDieSet       death tracking for losing side
```

### Singleton behavior

`BattleManager.Instance` lazily uses `FindObjectOfType<BattleManager>()`. `Start()` assigns `_instance = this` and initializes all major collections.

This means the scene must contain the expected `BattleManager` GameObject/component before code relying on `Instance` can work.

## BattleLineManager

`BattleLineManager` maintains separate dictionaries for left/right fighters and maps fighter IDs to a `SmallLineInfo` containing:

- small line index
- fighter ID
- `BattleHeroInfo`

Implemented operations include:

- `SetFighterSmallLine`
- `RemoveFighter`
- `ClearAll`
- `GetMainFighterInLine`

### Dependency

```text
BattleManager.RegisterBattleHero
       ↓
BattleManager.AddToLineManager
       ↓
BattleLineManager.SetFighterSmallLine
```

This is a confirmed source-level dependency path.

## BattleHeroInfo

`BattleHeroInfo` is a runtime data object created from `ReportHeroInfo`.

State includes:

- FighterId / HeroId
- side (`IsLeft`)
- passer flag
- line/origin line/small line/column
- HP / Spirit
- active/passive skills
- profession/gender
- `HeroObject`
- passive skill state

Its constructor is currently empty in the inspected source, so mapping from protocol data to runtime state is **NOT VERIFIED**.

## SkillCtrller

`SkillCtrller : MonoBehaviour` is the per-skill runtime controller.

### Confirmed responsibilities

- Store skill/source/target IDs.
- Initialize from direct IDs or `SkillEffectProto`.
- Collect harm, buff, property and other-effect protocol records.
- Track combo/batter information.
- Track duel winner.
- Interact with PlayMaker FSM objects.
- Resolve hit result as Dodge/Block/Hurt.
- Notify `BattleManager` when a target is marked dead.
- Create/destroy/clear skill runtime state.

### Confirmed flow

```text
BattleManager.CreateSkill(skillId)
    ↓
new GameObject("Skill_" + skillId)
    ↓
AddComponent<SkillCtrller>()
    ↓
BattleSkillInfo created
    ↓
BattleManager.RegisterBattleSkill()
```

This means battle skills are created dynamically, not necessarily pre-existing as scene objects.

### Protocol boundary

`SkillCtrller` consumes:

- `SkillEffectProto`
- `BuffAddProto`
- `BuffActionEffectProto`
- `HarmInfoProto`
- `PropertyChangeProto`

This makes the battle engine tightly coupled to protocol DTOs.

## Battle action surface

`BattleManager` contains handlers for protocol actions including:

- Buff add/effect/delete
- Enter battle
- Final competition
- Spirit changes
- Group HP changes
- Normal attack
- Skill effect
- Move to new line
- Turn-over sign

Many handlers currently return `false` or have empty bodies. This is a major runtime verification target.

## Battle lifecycle hypothesis

```text
Stage2_Main
   ↓
Battle transition
   ↓
Stage3_Battle
   ↓
BattleManager.Start
   ↓
Hero registration
   ↓
BattleLineManager placement
   ↓
Battle report/actions
   ↓
SkillCtrller / FSM
   ↓
Damage / Buff / Death
   ↓
Result / Replay / Exit
```

Only the internal class relationships are partially source-verified. The scene transition and full runtime lifecycle remain to be confirmed in Unity.

## Impact

**CRITICAL.** `BattleManager` is a central coordinator with many dependencies and should not be refactored casually.

## Debug checkpoints

1. `Stage3_Battle` contains `BattleManager`.
2. `BattleManager.Start()` executes.
3. `BattleLineManager.Instance` resolves.
4. Hero registration populates `battleHeroDic`.
5. Hero line placement succeeds.
6. Skill creation produces `SkillCtrller`.
7. Protocol action reaches the expected handler.
8. Skill FSM child messages complete.
9. Death state updates correctly.
10. Battle result/replay path executes.
