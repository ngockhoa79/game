using System;
using System.Collections;
using UnityEngine;

public class UIDictItem : IceUIBase
{
	public UITexture FG_Image;

	public UISprite FG_Frame;

	public UISprite AttributeIcon;

	public UILabel ItemName;

	public UISprite[] StarsIcon;

	public UISprite InactiveMask;

	public UISprite UnknownMask;

	public GameObject RootObject;

	public UIEventListener ItemButton;

	public Action E_OnTextureLoadComplete;

	private IllustDictUniformData itemData;

	protected IEnumerator currentCoroutine;

	public bool IsLocked { get; private set; }

	public bool IsUnknown { get; private set; }

	public void SetData(IllustDictUniformData uniformData)
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

	public void SetStar(int starNum)
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void OnItemClicked(GameObject gameObj)
	{
	}

	public bool LoadTexture()
	{
		return false;
	}

	public void SmartClearTexture()
	{
	}

	public void ClearTexture()
	{
	}

	public void ClearData()
	{
	}
}
