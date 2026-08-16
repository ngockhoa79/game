using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeCardListItem : MonoBehaviour
{
	public const float SERVING_ALPHA = 0.3f;

	public UIAeCardDragger Dragger;

	public UIAeCardDisplayer Portrait;

	public UILabel NameText;

	public UILabel LevelText;

	public UISprite ServingIndicator;

	public UICmStarDisplayer Star;

	private bool isServing;

	private bool isDragging;

	public bool IsServing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDragging
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<Hero> OnClick
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

	private void clear()
	{
	}

	private void set(Hero card)
	{
	}

	private void Start()
	{
	}
}
