using System;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;
using Spine;
using Spine36;
using Spine36.Unity;
using SpineWWW;
using SpineWWW.Unity;
using UnityEngine;

public class UIMainHeroCtrller : MonoBehaviour
{
	public static int heroId;

	public UIMainHeroInfoCtrller infoCtrller;

	private GameObject heroObject;

	private SkeletonAnimation skeletonAnimation;

	private SpineWWW.Unity.SkeletonAnimation skeletonAnimationNew;

	private Spine36.Unity.SkeletonAnimation skeletonAnimation36;

	private bool playLoopAnim;

	private bool waiting;

	private float waitTimer;

	private float loopTimer;

	private VoiceTemplate voiceTemp;

	public static string[] randomAnims;

	private HashSet<string> loopAnimSet;

	private Action loadCallBack;

	private bool isNewSpine;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetPlayStart()
	{
	}

	private void SetPlayOver()
	{
	}

	public void SetInfo(Hero _hero)
	{
		if (infoCtrller != null)
		{
			infoCtrller.SetInfo(_hero);
		}
	}

	public void CreateHero(int _heroId, Action _callBack)
	{
		heroId = _heroId;
		loadCallBack = _callBack;
		// [RECOVERED]
		Hero heroData = (Me.Ins != null && Me.Ins.HeroList != null) ? Me.Ins.HeroList.FindByLocalID(_heroId) : null;
		if (heroData != null)
		{
			SetInfo(heroData);
		}
		loadCallBack?.Invoke();
	}

	private void LoadCallback(UnityEngine.Object go)
	{
		if (go is GameObject obj)
		{
			heroObject = obj;
		}
	}

	private void OnClick()
	{
		Debug.Log($"[HERO-CTRL] OnClick for heroId={heroId}");
		RandomAnim();
	}

	private void RandomAnim()
	{
		Debug.Log("[HERO-CTRL] Playing random pose animation");
	}

	private void animationEnd(Spine.AnimationState state, int trackIndex, int loopCount)
	{
	}

	private void animationEnd1(SpineWWW.TrackEntry obj)
	{
	}

	private void animationEnd2(Spine36.TrackEntry obj)
	{
	}

	public GameObject GetHeroObject()
	{
		return heroObject;
	}
}
