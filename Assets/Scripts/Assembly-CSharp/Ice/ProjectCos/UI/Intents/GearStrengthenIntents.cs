using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class GearStrengthenIntents : IceUIIntent
	{
		public enum ETab
		{
			Levelup = 0,
			Refine = 1,
			_NUM = 2
		}

		private GearHolding holding;

		private int enterTab;

		private const string IntentKeyword = "UIGearStrengthen";

		public GearHolding Holding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		public GearStrengthenIntents(GearHolding holding, ETab enterTab)
		{
		}

		public void SetData(GearHolding holding, ETab enterTab)
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
