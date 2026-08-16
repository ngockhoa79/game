using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class ItemChat : MonoBehaviour
{
	public UILabel lbTypeOrGuildTitle;

	public UILabel lbName;

	public UILabel lbTime;

	public UILabel lbChatText;

	public UISprite spChatType;

	public UISprite spVIP;

	public UISprite spBubbleBg;

	public UISprite IconGuildLeader;

	public UISprite IconGuildViceLeader;

	public UIEventListener eventHeader;

	public UIEventListener eventMessageClick;

	public Action<S2CChatNtf> E_OnHeaderClick;

	public Action<S2CChatNtf> E_OnMessageClick;

	public UIAeCardDisplayer Header;

	private S2CChatNtf mData;

	private DateTime MyTime;

	private void Start()
	{
	}

	public void SetData(S2CChatNtf msg)
	{
	}

	private void Update()
	{
	}

	public void SetDataWorldChat(S2CChatNtf msg)
	{
	}

	public void SetDataGuildChat(S2CChatNtf msg)
	{
	}

	private void SetName(S2CChatNtf msg)
	{
	}

	private void SetTime(S2CChatNtf msg)
	{
	}

	public void SetHeader(S2CChatNtf msg)
	{
	}

	private void updateBublleBg()
	{
	}
}
