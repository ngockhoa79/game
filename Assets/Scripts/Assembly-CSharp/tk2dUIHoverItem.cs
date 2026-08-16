using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/tk2dUIHoverItem")]
public class tk2dUIHoverItem : tk2dUIBaseItemControl
{
	public GameObject outStateGO;

	public GameObject overStateGO;

	private bool isOver;

	public string SendMessageOnToggleHoverMethodName;

	public bool IsOver
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<tk2dUIHoverItem> OnToggleHover
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

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HoverOver()
	{
	}

	private void HoverOut()
	{
	}

	public void SetState()
	{
	}
}
