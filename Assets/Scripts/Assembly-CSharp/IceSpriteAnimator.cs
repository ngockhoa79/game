using System.Collections.Generic;
using UnityEngine;

public class IceSpriteAnimator : IceAnimator
{
	protected UISprite mSprite;

	[HideInInspector]
	[SerializeField]
	private string mPrefix;

	private int mIndex;

	private List<string> mSpriteNames;

	public string namePrefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IceSpriteAnimator()
		: base(0)
	{
	}

	protected override void Interpolate(params float[] args)
	{
	}

	public override void CopyTo(IceAnimator target)
	{
	}

	protected void _RebuildSpriteList()
	{
	}
}
