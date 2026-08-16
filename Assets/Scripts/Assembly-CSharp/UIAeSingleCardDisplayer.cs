using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeSingleCardDisplayer : MonoBehaviour
{
	public UISprite Portrait;

	[SerializeField]
	protected UITexture ImageTexture;

	private Hero card;

	private HeroConfig config;

	private int defaultID;

	public Action OnTexDone;

	public bool isAutoFit;

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

	public HeroConfig Config
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int DefaultID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void initTexture()
	{
	}

	private void set(Hero card)
	{
	}

	private void set(HeroConfig config)
	{
	}

	private void set(int id)
	{
	}

	protected virtual void initIcon(Hero card)
	{
	}

	protected virtual void initIcon(HeroConfig config)
	{
	}

	protected virtual void initIcon()
	{
	}
}
