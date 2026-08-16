using System;
using System.Collections.Generic;

public class UIItemPool<UI_T>
{
	public delegate UI_T CreateDelegage();

	private CreateDelegage mCreate;

	private Action<UI_T> mDel;

	private Queue<UI_T> mPool;

	public UIItemPool(CreateDelegage c, Action<UI_T> delDeleage = null)
	{
	}

	public UI_T GetUI()
	{
		return default(UI_T);
	}

	public void Reuse(UI_T ui)
	{
	}

	public void Reuse(List<UI_T> listUi)
	{
	}

	public void ClearDelete()
	{
	}
}
