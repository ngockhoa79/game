using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ActivityLotteryIntent : IceUIIntent
	{
		private ActivityChapter mAc;

		private ActivityLevel mLv;

		private List<ThingHolding> mAwardList;

		private List<int> mUsedStep;

		private GuessIterator mGuess;

		private const string IntentKeyword = "ActivityLottery";

		public new bool Revoke { get; set; }

		public ActivityLotteryIntent(ActivityChapter ac, ActivityLevel lv, List<ThingHolding> awardList, List<int> usedStep)
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

		protected override void EnterScreen(Action callback, bool playEffects)
		{
		}
	}
}
