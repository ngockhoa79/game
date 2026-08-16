using System;

namespace Ice.ProjectCos.UI.Intents
{
	public class PveIntents : IceUIIntent
	{
		private const string IntentKeyword = "PVE";

		protected int mChapterID;

		private bool bSetData;

		public Action OnEnterFinished;

		public PveIntents()
		{
		}

		public PveIntents(int chapterID)
		{
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

		protected override void DoInit()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		protected override void EnterScreen(Action callback, bool playEffects)
		{
		}

		protected override void DisposeScreen(Action callback, bool playEffects)
		{
		}

		protected override void ClearPanelData()
		{
		}

		public override void ReleaseResources()
		{
		}

		private void OnPveClosed()
		{
		}

		private void OnOpenChapter(int chapterId)
		{
		}

		protected override bool EnforceAssistantOn()
		{
			return false;
		}
	}
}
