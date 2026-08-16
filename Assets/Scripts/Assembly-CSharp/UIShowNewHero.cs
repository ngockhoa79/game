using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIShowNewHero : MonoBehaviour
{
	public UIHeroLoader HeroLoader;

	public UISprite spNewHeroTitle;

	public UILabel lbNewHeroDesc;

	public Action E_OnComplete;

	public UIEventListener eventHero;

	private HeroConfig mHc;

	private void Start()
	{
	}

	public void Clear()
	{
	}

	public void SetData(HeroConfig hc, Action onComplete, bool isNew)
	{
	}

	public void OnNewHeroLoaded(bool isSucess)
	{
	}

	private void OnDestroy()
	{
	}
}
