using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIGuildPartyMenuItem : MonoBehaviour
{
	private string[] TitleSprites;

	private string[] IconSprites;

	public UILabel LbHYD;

	public UILabel LbJL;

	public UILabel LbCrystal;

	public UIEventListener OpenBtn;

	public UISprite Title;

	public UISprite Icon;

	public UISprite Line;

	public GameObject Obtained;

	public float PositionUp;

	public float PositionDown;

	public void Set(bool isSingle, bool show, GuildPartyTemplate t, Action<GuildPartyTemplate> onClicked)
	{
	}
}
