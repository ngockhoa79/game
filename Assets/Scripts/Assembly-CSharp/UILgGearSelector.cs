using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgGearSelector : IceUIBase, IceUIReusableList<ItemHolding>.IVisualizer
{
	[SerializeField]
	private UIEventListener homePageBtn;

	[SerializeField]
	private UIEventListener returnBtn;

	[SerializeField]
	private IceUIBtnGroup filter;

	[SerializeField]
	private UILgList list;

	public string CurrentTabButton { get; private set; }

	public string NewTabButton { get; private set; }

	public event Action<GearHolding> OnSelect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnHomePage
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnReturn
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, ItemHolding item)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	private void set(string filter, List<GearHolding> gears)
	{
	}

	public void Set(string filter, List<GearHolding> gears)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	private void OnActiveTabUI()
	{
	}
}
