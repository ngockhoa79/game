using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAefFriendCardListItem : MonoBehaviour
{
	public Action<Player> OnClick;

	public const float SERVING_ALPHA = 0.3f;

	private const string SpriteNameFriend = "AefHaoYou";

	private const string SpriteNameStranger = "AefMoShengRen";

	public UIAeCardDragger Dragger;

	public UIAeCardDisplayer Portrait;

	public UILabel FriendPointGainText;

	public UISprite PlayerTypeSpec;

	public UILabel PlayerNameText;

	public UILabel CardLevelText;

	public UILabel CardSkillNameText;

	private Player player;

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

	public Player Player
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Dispose()
	{
	}

	private void clear()
	{
	}

	private void set(Player player)
	{
	}

	private void Start()
	{
	}
}
