using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SelectGearIntent : IceUIIntent
	{
		private const string IntentKey = "GearSelector";

		private const string ResCategory = "uiluggage";

		public Hero Card { get; private set; }

		public EGearSlot GearSlot { get; private set; }

		public GearHolding SelectedGear { get; private set; }

		public SelectGearIntent(Hero card, EGearSlot gearSlot)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void commit(GearHolding gear, EGearSlot GearSlot)
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
