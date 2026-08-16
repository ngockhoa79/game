using System;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class ItemItemDropFrom : IceUIBase
{
	public UISprite spIcon;

	public UISprite spTypeNormal;

	public UISprite spTypeHero;

	public UITexture txIcon;

	public GameObject BGNormal;

	public GameObject BGDrak;

	public GameObject PVELevelPart;

	public GameObject UIPart;

	public UILabel lbChataNum;

	public UILabel lbChataDesc;

	public UILabel lbProgress;

	public UILabel lbUIName;

	public UILabel lbProgressMax;

	public UIButton bnGo;

	public UIEventListener eventRoot;

	public IceAnimatorTotalCommander anim_in;

	private Navigator mData;

	private PVELevel mPVELv;

	private bool mCanGo;

	private bool mEnable;

	public Action<Navigator, PVELevel> OnGotoLevel;

	public Action<Navigator> OnGotoUI;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetDataPveLevel(Navigator n)
	{
	}

	public void SetDataPveLevel(PVELevel data)
	{
	}

	public void Clear()
	{
	}

	public void SetStatusEnable(bool isEnable)
	{
	}

	private void loadTexture(string name)
	{
	}

	public void OnGoClick()
	{
	}
}
