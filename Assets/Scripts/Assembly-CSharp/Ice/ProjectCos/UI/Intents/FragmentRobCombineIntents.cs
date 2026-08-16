using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class FragmentRobCombineIntents : IceUIIntent
	{
		public enum EState
		{
			Able = 0,
			FragmentZero = 1,
			LevelNotEnough = 2
		}

		private const string IntentKeyword = "FragmentCombine";

		private Skill defaultSkill;

		private bool bCombining;

		public void SetDefaultSkill(Skill skill)
		{
		}

		public static EState AbleToPerform()
		{
			return default(EState);
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}

		private void handleBatch(List<int> ids)
		{
		}

		private void ApplyResponse(object response, int _skillFragment)
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		private void OnMessageResponse(object response)
		{
		}

		private void tip(string str)
		{
		}
	}
}
