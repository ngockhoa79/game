using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPortraItem : IceUIBase
{
	public UITexture FG_Image;

	public UISprite FG_Frame;

	public GameObject RootObject;

	public UIEventListener ItemButton;

	private HeroConfig itemData;

	public Action<int> E_PortraClicked;

	public void SetData(HeroConfig heroData)
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

	public void OnItemClicked(GameObject gameObj)
	{
	}

	public void LoadTexture()
	{
	}

	public void ClearTexture()
	{
	}
}
