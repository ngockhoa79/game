using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UITrailAwardPopup : UIPVPAwardPopup
{
	public UIScrollView usvList;

	private List<ShopAwardData> mListGuard;

	private List<ShopAwardData> mListBoss;

	[SerializeField]
	private IceUIBtnGroup Tab;

	private void Start()
	{
	}

	private void loadData()
	{
	}

	public void AddDataFromTrailGuard()
	{
	}

	public void AddDataFromTrailBoss()
	{
	}
}
