namespace Ice.ProjectCos.UI.Intents
{
	public class IllustDictIntent : IceUIIntent
	{
		public enum ETab
		{
			Coser = 0,
			Gear = 1,
			Skill = 2,
			Invalid = 3
		}

		private const string IntentKeyword = "IllustDict";

		private ETab enterTab;

		public IllustDictBaseController.Filter RememberCoserFilter;

		public IllustDictBaseController.Filter RememberGearFilter;

		public IllustDictBaseController.Filter RememberSkillFilter;

		public int RememberCoserPage;

		public int RememberGearPage;

		public int RememberSkillPage;

		public ETab RememberTab
		{
			get
			{
				return default(ETab);
			}
			set
			{
			}
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		public IllustDictIntent(ETab enterTab)
		{
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

		protected override void OnGetToBackgorund()
		{
		}

		public override void DoDispose()
		{
		}

		private void OnHome()
		{
		}

		private void OnReturn()
		{
		}
	}
}
