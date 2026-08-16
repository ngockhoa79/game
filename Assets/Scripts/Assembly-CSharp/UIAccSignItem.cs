using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAccSignItem : IceUIBase
{
	public UISprite BG_L;

	public UITexture FG_Image;

	public UISprite FG_Frame;

	public GameObject RootObject;

	public GameObject CountGroup;

	public UILabel CountLabel;

	public GameObject VIPGroup;

	public UILabel VIPLabel;

	public GameObject GotMask;

	public GameObject ChipMask;

	public GameObject ReadyItemAni;

	public GameObject StarsGroup;

	public UISprite[] StarsIcon;

	public int LocalID;

	public UIEventListener ItemButton;

	private ThingHolding itemData;

	private int Day;

	private TipTriger ItemTip;

	public void SetData(ThingHolding data, int day)
	{
	}

	protected void SetupUI()
	{
	}

	public void SetStars(int starNum)
	{
	}

	public void RefreshState()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void LoadTexture()
	{
	}

	public void ClearTexture()
	{
	}

	public void BindTip()
	{
	}

	public void UnbindTip()
	{
	}
}
