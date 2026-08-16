using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICeCardDisplayer : MonoBehaviour
{
	private Rect LayoutRect;

	public UISprite Profession;

	public UISprite Frame;

	public IceAnimatorTotalCommander Leader;

	public GameObject OnBoard;

	public UITexture Portrait;

	private Hero card;

	private HeroConfig config;

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

	public bool IsLeader
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(Hero card)
	{
	}

	private void set(HeroConfig config)
	{
	}

	private void Start()
	{
	}

	public void ActivateOnBoard()
	{
	}
}
