using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public abstract class UISelectPortraSectionBase : MonoBehaviour
{
	public GameObject ItemAnchorPoint;

	public Action<int> E_OnItemClicked;

	protected List<HeroConfig> HeroList;

	private List<UIPortraItem> PortraList;

	protected int HeaderHeight;

	protected int EnderHeight;

	protected abstract void LoadInternalData();

	protected abstract void ClearInternalData();

	public abstract int GetSectionHeight();

	public virtual void Prepare()
	{
	}

	public void ClearData()
	{
	}

	protected void ClearTextureData()
	{
	}

	public void OnItemClicked(int heroID)
	{
	}
}
