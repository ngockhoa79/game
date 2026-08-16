using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIShowCardMuti : MonoBehaviour
{
	public int MaxSubCardCount;

	public float AnimateInterval;

	public IceAnimatorTotalCommander AllAnimator;

	private List<IceAnimatorTotalCommander> SubAnimators;

	public Transform CardTrackAll;

	private List<Transform> SubTracks;

	public UIShowCardBgAnimate BGAnimator;

	public Action E_OnComplete;

	public Action E_OnPreloadComplete;

	private List<ItemHolding> mShowData;

	private List<ItemCardForDraw> mCreatedMidCard;

	private int mShow1by1Step;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Clear()
	{
	}

	public void SetShowingCard(List<Hero> showHeros)
	{
	}

	public void SetShowingData(List<ItemHolding> showData)
	{
	}

	private void ShowAllCardOnce()
	{
	}

	public void ShowAllCard1By1Begin()
	{
	}

	public void ShowAllCard1By1Next(Action onStepComplete)
	{
	}

	private void loadCardToTrack()
	{
	}

	private void unloadCard()
	{
	}

	private void findSubAnimator()
	{
	}

	private void findSubTrack()
	{
	}

	private void OnShowComplete()
	{
	}
}
