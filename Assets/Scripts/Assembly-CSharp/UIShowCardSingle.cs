using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIShowCardSingle : MonoBehaviour
{
	public UIShowNewHero ShowNewHeroUI;

	public UIShowCardBgAnimate BGAnimate;

	public Transform[] CardMoveTrackByRarity;

	public Action E_OnShowComplete;

	public Action E_OnShowError;

	public Action E_OnPreloadComplete;

	public UILabel lbDrawCountDown;

	[HideInInspector]
	public bool IsShowModeOnly;

	public UIShowCardButton BtnCtrolSingle;

	public IceAnimatorTotalCommander mMoveLeftAnimator;

	private IceAnimatorTotalCommander mUsingMoveTrack;

	private IceScalingAnimator mTrackTimer;

	private CardBig Card1;

	private CardBig Card2;

	private CardBig Card3;

	private Hero mShowingCardHolding;

	private HeroConfig mShowingCard;

	private ProcedureManchine mProceduceOneCard;

	private ProcedureLine mOneCardShowLine;

	private ProcedureLine mOneCardShowNewLine;

	private bool called;

	public static string[] ActionNames;

	public Hero ShowingCard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetShowingCard(Hero hero)
	{
	}

	public void BeginShow()
	{
	}

	public void CreateProcedure()
	{
	}

	private void loadShowingCardStep()
	{
	}

	private bool loadShowingCard()
	{
		return false;
	}

	private void loadCardToSlot(Transform parent, string childName, HeroConfig heroConfigToAdd, out CardBig createdCard)
	{
		createdCard = null;
	}

	private void onCardTextureLoad(CardBig card)
	{
	}

	private void unloadShowingCard()
	{
	}

	private void showingCardOutStep()
	{
	}

	private void hideOtherCard()
	{
	}

	public void ClearSingleShow()
	{
	}

	private void playCardMoveInAnimationStep()
	{
	}

	private void playCardMoveOutAnimationStep()
	{
	}

	private void onActionCardMoveOutComplete()
	{
	}

	private void newHeroPlay()
	{
	}

	public void ShowDrawCountDownAuto()
	{
	}

	public void ShowDrawCountDown(bool isShow = true)
	{
	}

	private void playHeroRandom()
	{
	}

	private void playBGSound()
	{
	}
}
