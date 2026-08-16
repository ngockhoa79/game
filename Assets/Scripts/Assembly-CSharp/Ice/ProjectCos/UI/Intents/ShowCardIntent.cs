using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ShowCardIntent : IceUIIntent
	{
		private const string IntentKeyword = "ShowCard";

		private C2SHeroLotteryReq.LotteryType mDrawType;

		private List<ItemHolding> mHeroToShow;

		private bool mIsShowOnly;

		private Action OnEndCallback;

		private Action<UIShowCard> OnLoadComplete;

		public ShowCardIntent(List<ItemHolding> heroesToShow, bool isShowOnly, Action callback = null, Action<UIShowCard> loadCompleteCallback = null)
		{
		}

		public static bool AbleToPerform()
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
	}
}
