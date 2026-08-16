using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/tk2dUIDropDownItem")]
public class tk2dUIDropDownItem : tk2dUIBaseItemControl
{
	public tk2dTextMesh label;

	public float height;

	public tk2dUIUpDownHoverButton upDownHoverBtn;

	private int index;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string LabelText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<tk2dUIDropDownItem> OnItemSelected
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ItemSelected()
	{
	}
}
