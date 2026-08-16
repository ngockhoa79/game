using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardStrengthenIntent : IceUIIntent
	{
		public enum ETab
		{
			Levelup = 0,
			Wakeup = 1,
			Nurture = 2,
			BaQi = 3,
			_NUM = 4
		}

		private Hero hero;

		private ETab enterTab;

		private const string IntentKeyword = "CardStrengthen";

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		public CardStrengthenIntent(Hero hero = null, ETab _tab = ETab.Levelup) : base()
		{
			this.hero = hero;
			this.enterTab = _tab;
		}

		public CardStrengthenIntent(Hero hero, ETab enterTab, bool isFromOutside) : base()
		{
			this.hero = hero;
			this.enterTab = enterTab;
		}

		public void SetData(Hero _hero, ETab _tab)
		{
			this.hero = _hero;
			this.enterTab = _tab;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				UIPanel panel;
				if (panelCollector.TryGetPanel("CardStrengthen", out panel))
				{
					return panel;
				}
				panel = UILoader.Load<UIPanel>("UICardStrengthen", "cardstrengthen", panelCollector.transform);
				if (panel != null)
				{
					panelCollector.RegistPanel("CardStrengthen", panel);
				}
				return panel;
			}
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		public override void DoDispose()
		{
		}

		public void RefrushTab(ETab _tab)
		{
		}
	}
}
