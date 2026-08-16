using System;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class FormationChangeBeforeBattleIntent : IceUIIntent
	{
		private const string IntentKeyword = "FormationChangeBeforeBattleIntent";

		public Action OnFail;

		public Action<Friend> OnSuccess;

		private bool mIsPVE;

		private Friend mFriend;

		private bool mAutoRevoke;

		public int LevelFormationID { get; set; }

		public FormationChangeBeforeBattleIntent(int formationID, Action<Friend> onSuccess, Action onFail = null)
		{
		}

		public FormationChangeBeforeBattleIntent(Friend f, Action<Friend> onSuccess, Action onFail = null)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void clickEditArray()
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

		public void OnRequestBattle()
		{
		}

		private void autoRevoke(Action onComplete)
		{
		}

		public void OnBack()
		{
		}

		public void OnHome()
		{
		}
	}
}
