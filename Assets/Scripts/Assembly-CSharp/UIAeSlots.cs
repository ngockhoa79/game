using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeSlots : IceUIBase
{
	public ArrayCircumstance circumstance;

	public float GridWidth;

	public float GridHeight;

	private Vector3 TradeSelectorOffset;

	private const string AcColumnSlot = "AcColumnSlot";

	private const string BackGround = "Background";

	private int Total;

	public Func<Hero, bool> GetOffTester;

	public List<UIAeSlot> Slots;

	public BoxCollider[] FallBackSlots;

	public ArrayMatrixIndexMapper mapper;

	public bool IsReadonly;

	public bool IsLeftToRight;

	public bool IsTopToBottom;

	public Transform AlignmentPoint;

	public UILeaderSkillSingleLine SingleLine;

	public UILeaderSkillMultiLines MultiLines;

	[HideInInspector]
	public bool PVERedRarity;

	[HideInInspector]
	public int[] BossPositions;

	private BattleArray array;

	public UILockedColumnDisplayer LockedColumn;

	public BattleArray Array
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<UIAeCardDragger, int> OnFallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Hero> OnClickCard
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<UIAeCardDragger> OnAnyCardBeingDragged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<UIAeCardDragger> OnAnyCardDropped
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void clear()
	{
	}

	private void shrinker(BattleArray array)
	{
	}

	private void extender(int targetIndex, Hero card, bool available)
	{
	}

	private void set(BattleArray array)
	{
	}

	private void indicateVacancyStatus(BattleArray battleArray, int row, int col, Hero hero)
	{
	}

	private void defaultTradeSelector(BattleArray array, Hero defaultHero)
	{
	}

	private void clearTradeSelectors(UIAeSlot freshSlot)
	{
	}

	public void RemoveTradeSelectorsEvent()
	{
	}

	private Transform findBackground(UIAeSlot slot)
	{
		return null;
	}

	private void handleTradeSelectorClicked(UIAeSlot slot)
	{
	}

	private void stretchArrayEditorLayout(BattleArray array)
	{
	}

	private void stretchArrayConfirmLayout(BattleArray array)
	{
	}

	private void stretchArrayLayout(BattleArray array)
	{
	}

	private void activateCheerMark(BattleArray array)
	{
	}

	private void handleLeaderSkillDescs(BattleArray array, int row, int col, Hero arg4)
	{
	}

	public void Set(int slotIndex, Hero card)
	{
	}

	private int findSlot(UIAeCardDragger dragger)
	{
		return 0;
	}

	private void handleLeaderChanged(BattleArray array, CaptainMisc oldLeader, CaptainMisc newLeader)
	{
	}

	private void setSlotCaptain(BattleArray array, CaptainMisc misc)
	{
	}

	private UIAeSlot findSlot(BattleArray ary, int local)
	{
		return null;
	}

	private void updateAeLeaderSkills(BattleArray ary)
	{
	}

	private void updateAcLeaderSkills(BattleArray ary)
	{
	}

	private void onPressed(IceUIDragItem item)
	{
	}

	private void onReleased(IceUIDragItem item)
	{
	}

	private void onEnterSlot(IceUIDragItem item, int slotIndex)
	{
	}

	private void onLeaveSlot(IceUIDragItem item, int slotIndex)
	{
	}

	private void onPutIntoSlot(IceUIDragItem item, int anotherSlotIndex)
	{
	}

	private void puppetSwap(int thisSlot, int anotherSlot, bool firstIsPuppet = true)
	{
	}

	private void putIntoArrayEditor(int thisSlotIndex, int anotherSlotIndex)
	{
	}

	private void putIntoArrayConfirm(int thisSlotIndex, int anotherSlotIndex)
	{
	}

	private void switchDraggerResetMethod(UIAeCardDragger dragger)
	{
	}

	private void onEnterFallBackSlot(IceUIDragItem item, int slotIndex)
	{
	}

	private void onLeaveFallBackSlot(IceUIDragItem item, int slotIndex)
	{
	}

	private void onFallBack(IceUIDragItem item, int slotIndex)
	{
	}

	private void onInvalidDrag(IceUIDragItem item)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void prepareOneSlot(int r, int c, UIAeSlot slot, int bgNameIndex)
	{
	}

	private void prepareOnePuppetSlot(UIAeSlot slot)
	{
	}

	protected override void DoClearData()
	{
	}

	private void resetSlotsPos()
	{
	}

	protected override void DoDispose()
	{
	}

	private void bindSlotEvents(UIAeCardDragger dragger)
	{
	}

	private void clearSlotEvents()
	{
	}

	private void anyCardBeingDragged(UIAeCardDragger dragger)
	{
	}

	private void anyCardDropped(UIAeCardDragger dragger)
	{
	}

	public void ShowAllRestrains(BattleArray left, BattleArray right)
	{
	}

	public void ClearAllRestrains()
	{
	}

	private void handleSupportIconChanged(BattleArray battleArray, int row, int col, Hero hero)
	{
	}

	private void supportsIconsChanged(BattleArray ary, bool mine)
	{
	}
}
