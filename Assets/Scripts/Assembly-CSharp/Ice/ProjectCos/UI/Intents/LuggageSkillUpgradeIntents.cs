using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class LuggageSkillUpgradeIntents : IceUIIntent
	{
		private SkillHolding target;

		private List<IceUIBase> visiblePrompts;

		private const string IntentKeyword = "SkillUpgrader";

		private int MatSlotId;

		public LuggageSkillUpgradeIntents()
		{
		}

		public LuggageSkillUpgradeIntents(SkillHolding _target)
		{
		}

		public void SetMaterialSlot(int _slot, SkillHolding _mat)
		{
		}

		public void SetSkill(SkillHolding skill)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
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

		protected override void ClearPanelData()
		{
		}

		private void OnItemCart(List<ItemHolding> holdings)
		{
		}

		private void OnMatCart(List<ItemHolding> holdings)
		{
		}

		private void activateFailurePrompt(GameObject parent, object cause)
		{
		}

		private void onUpgradeSkill(SkillHolding target, List<SkillHolding> sacrifices, int[] stoneUsages)
		{
		}

		private void clearPrompts()
		{
		}
	}
}
