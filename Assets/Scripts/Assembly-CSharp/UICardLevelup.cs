using System;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardLevelup : IceUIBase
{
	[SerializeField]
	private UICardLevelupHeadCtrller HeadCtrller;

	[SerializeField]
	private UICardLevelupDataCtrller DataCtrller;

	[SerializeField]
	private UICardLevelupMatGroupCtrller MatGroupCtrller;

	[SerializeField]
	private UICardLevelupExpCtrller ExpCtrller;

	[SerializeField]
	private UILabel CoinLabel;

	[SerializeField]
	private UICardLevelupSuccessCtrller SuccessCtrller;

	[SerializeField]
	private UIEventListener LvupBtn;

	[SerializeField]
	private IceAnimatorTotalCommander MainCardPickAnim;

	[SerializeField]
	private IceAnimatorTotalCommander ExpOverAnim;

	[SerializeField]
	private IceAnimatorTotalCommander MatsPickAnim;

	[SerializeField]
	private IceAnimatorTotalCommander LvupBtnAnim;

	[SerializeField]
	private IceAnimatorTotalCommander LvupClickAnim;

	private bool selectNewMainCard;

	private bool selectNewMat;

	private int coinCounter;

	private Hero card;

	private HeroTemplateExt heroTemplate;

	private bool IsIllegalState => false;

	protected override void DoPrepare()
	{
	}

	public void ResetData(Hero _card)
	{
	}

	public void SetData(Hero _card, bool _needRefreshAll = true)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	private void Update()
	{
	}

	private void OnMatChanged()
	{
	}

	private void OnLevelupClicked(GameObject obj)
	{
	}

	private void SendLvupReq()
	{
	}

	public void OnLevelupMessage(object msg, int msgId)
	{
	}

	private void OnLevelupResponse(object response)
	{
	}

	private void HandleLevelup()
	{
	}
}
