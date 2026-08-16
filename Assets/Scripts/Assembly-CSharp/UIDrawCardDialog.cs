using System;
using System.Collections.Generic;
using UnityEngine;

public class UIDrawCardDialog : MonoBehaviour
{
	public UIEventListener EventDraw;

	public UIEventListener EventDraw10;

	public UIEventListener EventClose;

	public UIEventListener EventHelp;

	public UIEventListener EventRecord;

	public UIEventListener AddDrawItem;

	public UICostDisplayer CostDraw;

	public UICostDisplayer CostDraw10;

	public UILabel lbNextCount;

	public GameObject GroupFirstDraw;

	public GameObject GroupCountDraw;

	public GameObject GroupThisDraw;

	public UILabel lbFirstDraw;

	public UILabel lbFirstDraw10;

	public UILabel lbCountDrawItem;

	public ItemCardForDraw[] ShowRadomCardsGroup1;

	public ItemCardForDraw[] ShowRadomCardsGroup2;

	private ItemCardForDraw[] ShowingCards;

	private ItemCardForDraw[] HidingCards;

	private List<int> mIDs;

	private int mLoadComplete;

	private int DrawCardItemId;

	public Action E_OnDraw;

	public Action E_OnDraw10;

	public IceAnimatorTotalCommander EnterAnimate;

	public IceAnimatorTotalCommander ExitAnimate;

	public const float RefreshInterval = 1.5f;

	private bool mAnimating;

	private void Start()
	{
	}

	private int RefreshDrawItem()
	{
		return 0;
	}

	private void OnDestroy()
	{
	}

	public void SetUI()
	{
	}

	public void BindEvnet()
	{
	}

	private void OnHelpClicked(GameObject obj)
	{
	}

	private void setTitle()
	{
	}

	private void loadCardAtInit()
	{
	}

	private void drawRandomCardWithoutRepeat()
	{
	}

	private void loadNextGroupCard()
	{
	}

	private void onLoadComplete()
	{
	}

	private void switchShowingGroup()
	{
	}
}
