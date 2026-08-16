using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class MyCart
{
	private List<ItemHolding> mCartList;

	public int mMaxCount;

	public int MaxCount => 0;

	public int Count => 0;

	public int RestSpaceCount => 0;

	public MyCart(int maxSpce)
	{
	}

	public bool HasRestSpace()
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsInMyCart(ItemHolding itemH)
	{
		return false;
	}

	public List<ItemHolding> GetList()
	{
		return null;
	}

	public bool Add(ItemHolding itemH)
	{
		return false;
	}

	public int AddRange(List<ItemHolding> list)
	{
		return 0;
	}

	public int AddRange(ItemHolding[] list)
	{
		return 0;
	}

	public bool Remove(ItemHolding itemH)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void SetCapcity(int newCap)
	{
	}
}
