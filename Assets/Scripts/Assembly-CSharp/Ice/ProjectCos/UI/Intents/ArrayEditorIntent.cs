using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayEditorIntent : IceUIIntent
	{
		public static bool Halting;

		private const string IntentKey = "ArrayEditor";

		private const string ResCategory = "uiarrayeditor";

		private Hero card;

		private Friend mFriend;

		private bool showCtrl;

		private BattleArray array;

		public ArrayEditorIntent(Hero selected = null) : base()
		{
			this.card = selected;
		}

		public ArrayEditorIntent(Friend friend, bool showCtrl) : base()
		{
			this.mFriend = friend;
			this.showCtrl = showCtrl;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				UIPanel panel;
				if (panelCollector.TryGetPanel("ArrayEditor", out panel))
				{
					return panel;
				}
				panel = UILoader.Load<UIPanel>("UIArrayEditor", "uiarrayeditor", panelCollector.transform);
				if (panel != null)
				{
					panelCollector.RegistPanel("ArrayEditor", panel);
				}
				return panel;
			}
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		private void setFriend(UIArrayEditor ui)
		{
		}

		private void pushData(BattleArray ary, Hero hero, bool h)
		{
		}

		private void handleOnHome(bool commit)
		{
		}

		private void handleOnBack(bool commit)
		{
		}

		private void commitArray(bool commit)
		{
		}

		private void hollowOutActiveArray()
		{
		}

		private void strengthenCard(Hero hero)
		{
		}

		private void handleSetAsLeader(Hero leader)
		{
		}

		private void attach()
		{
		}

		private void detach()
		{
		}

		private void detachForFriend()
		{
		}

		private Hero dig(Hero card)
		{
			return null;
		}

		private void handleCardClicked(Hero hero)
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void clickTalent(Hero c)
		{
		}

		private void clickSkill(Hero c, int slot)
		{
		}

		private ESkillType filterType(int slot)
		{
			return default(ESkillType);
		}

		private void equipNewSkill(List<ItemHolding> holdings, int slot, Hero c)
		{
		}

		private void switchSkill(SkillHolding skillh, List<ItemHolding> holdings, int slot, Hero c, SkillHolding old)
		{
		}

		private void unloadSkill(int slot, SkillHolding sh, SkillHolding old)
		{
		}

		private SkillHolding update(SkillHolding skill)
		{
			return null;
		}

		private GearHolding update(GearHolding gear)
		{
			return null;
		}

		private Hero updateSkillsOnCard(Hero c)
		{
			return null;
		}

		private void clickGear(Hero c, EGearSlot slot)
		{
		}

		private void equipNewGear(List<ItemHolding> holdings, EGearSlot slot, Hero c)
		{
		}

		private void switchGear(GearHolding gearh, List<ItemHolding> holdings, EGearSlot slot, Hero c, GearHolding old)
		{
		}

		private void unloadGear(EGearSlot slot, GearHolding gh, GearHolding old)
		{
		}

		private Hero updateGearsOnCard(Hero c)
		{
			return null;
		}

		private void commit(GearHolding gear, EGearSlot GearSlot, Action successCallback)
		{
		}

		private void equipGearFail(NetManager.CoreErrorCode err_code = NetManager.CoreErrorCode.ErrorCodeUnknown)
		{
		}

		private void commit(SkillHolding skill, int SkillSlot, Action successCallback)
		{
		}

		private void equipSkillFail(NetManager.CoreErrorCode err_code = NetManager.CoreErrorCode.ErrorCodeUnknown)
		{
		}

		private void delFriend()
		{
		}

		private void handleOnDel()
		{
		}

		private void revokeCurrent()
		{
		}

		private void leaveMsgFriend()
		{
		}

		private void handleMsg(string str)
		{
		}

		private void qieCuoFriend()
		{
		}

		private void openQieCuoDialog()
		{
		}

		private void requestQieCuo(Friend f)
		{
		}

		private void gotoChangeFormation()
		{
		}

		private void showBattleLog()
		{
		}
	}
}
