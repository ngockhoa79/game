using System;
using System.Collections.Generic;
using UnityEngine;

public class GuildSearchListCtrller : MonoBehaviour
{
	public GameObject ListNode;

	public List<GameObject> Items;

	private int MAX_ITEMS;

	private Action<int> ItemClickCallBack;

	public void Prepare()
	{
	}

	public void SetData(List<GuildInfo> _guilds, Action<int> _callBack)
	{
	}

	public void ShowInfoByArrayIndex(int _index)
	{
	}

	private void LightItem(int _index)
	{
	}

	public void ClearData()
	{
	}

	private void GenItems()
	{
	}

	private void HideAll()
	{
	}
}
