using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAccSignPage : MonoBehaviour
{
	public GameObject ItemAnchorPoint;

	protected List<ThingHolding> dataItemList;

	private List<UIAccSignItem> uiItemList;

	protected int HeaderHeight;

	protected int EnderHeight;

	public void Prepare()
	{
	}

	public void RefreshItemsState()
	{
	}

	public void ClearData()
	{
	}

	protected void ClearTextureData()
	{
	}

	protected void LoadInternalData()
	{
	}

	protected void ClearInternalData()
	{
	}

	public ThingHolding GetItemInfoByDay(int day)
	{
		return null;
	}

	public int GetRowIndex(int day)
	{
		return 0;
	}

	public int GetRowCount()
	{
		return 0;
	}

	public int GetPageHeight()
	{
		return 0;
	}

	public int GetYCenterForRow(int row_num)
	{
		return 0;
	}

	public int GetYCenterForDay(int day)
	{
		return 0;
	}

	public void TotalRefresh()
	{
	}
}
