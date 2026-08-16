using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIActivityLottery : IceUIBase
{
	public UIEventListener eventHome;

	public UIEventListener eventBack;

	public UIGrid gdGuessItems;

	public UIGrid gdAwardItems;

	public UILabel lbEnery;

	public UILabel lbGuessStep;

	public GameObject ArrowLeft;

	public GameObject ArrowRight;

	public UIScrollView scrollAward;

	public UIPanel clipPanelAward;

	private List<ItemActivityGuess> mGuessCells;

	private int mAwartGot;

	public GameObject goAwardNPC;

	public UILabel lbGreatAwardNPCText;

	public IceAnimatorTotalCommander AnimateAwardNPC;

	public UIEventListener evStartBattle;

	[HideInInspector]
	public ActivityChapter mActivityChapter;

	[HideInInspector]
	public ActivityLevel mCurLevel;

	[HideInInspector]
	public GuessIterator mGuess;

	public IceAnimatorTotalCommander AnimaitonEnter;

	public IceAnimatorTotalCommander AnimationBattleStart;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void LoadInitGuessCell()
	{
	}

	private void bindAllItemAction(bool isBind)
	{
	}

	public void RequestGuessStepNext(int posIndex)
	{
	}

	public void SetGuessCellInfoAndAnimate(int positionIndex, ThingHolding th, bool animate, Action onComplete)
	{
	}

	public void AddToAwardList(ThingHolding th)
	{
	}

	public void SetInfo()
	{
	}

	public void ShowGuessInfoImmdedy(bool isPlayAnimation = false)
	{
	}

	public void AwardEndAndGoFight(bool showAnimate)
	{
	}

	private void gotoChangeFormation()
	{
	}

	private void requestPVE()
	{
	}

	private void showBattleLog()
	{
	}

	public void OnGuessCellClick(int index)
	{
	}

	private void autoShowGreatAwardNPCText(ThingHolding th)
	{
	}

	private void showGreatAwardNPCText(ThingHolding th)
	{
	}

	private void hideGreatAwardNPCText()
	{
	}

	private float getGirdWidth()
	{
		return 0f;
	}

	private void showHideArrow()
	{
	}
}
