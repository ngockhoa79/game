using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class PveChapterIntent : IceUIIntent
	{
		private int chapterId;

		private int selectedDuplicationID;

		private int duplicationId;

		private const string IntentKeyword = "PVEChapter";

		public PveChapterIntent(int chapterId, int duplicationId = -1)
		{
		}

		public void SetDuplicationId(int dupId)
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

		private void OnAddEnergy()
		{
		}

		private void OnPveChapterBack()
		{
		}

		private void OnPveChapter2MainPage()
		{
		}

		private void OnPveChapterContainerEnter(GameObject go, PVELevel data)
		{
		}

		private void OnSupportersReponse(GamePlayManner manner)
		{
		}

		private void OnPveChapterContainerSaoDang(GameObject go, PVELevel data)
		{
		}
	}
}
