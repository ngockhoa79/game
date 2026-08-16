using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ItemPopupIntent : IceUIIntent
	{
		private const string IntentKeyword = "ItemPopup";

		public Hero Card { get; private set; }

		public ItemHolding Holding { get; private set; }

		public EGearSlot GSlot { get; private set; }

		public ItemPopupIntent(Hero card, ItemHolding holding, EGearSlot gslot)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void ClearPanelData()
		{
		}

		protected override void SetPanelData()
		{
		}
	}
}
