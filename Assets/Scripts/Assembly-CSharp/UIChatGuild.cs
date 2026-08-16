using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIChatGuild : IceUIBase, IceUIReusableList<S2CChatNtf>.IVisualizer
{
	public IceUIBtnGroup TabButton;

	public UIEventListener CloseButton;

	public UIChatListAnimator ChatList;

	public UIPanel ListClipPanel;

	public C2SChatReq.TypeEnum ChatTypeToOpen;

	public UIInput InputText;

	public UIButton bnSend;

	public UIEventListener inputBtnWebGL;

	public GameObject UnReadTagWorld;

	public GameObject UnReadTagGuild;

	public UISprite spSendWorld;

	public UISprite spSendGuild;

	public UILabel lbWorldFreeTime;

	public UILabel lbWorldCostCrystal;

	private ChatChannel mCurChat;

	private Dictionary<C2SChatReq.TypeEnum, bool> mChannelNeedRefresh;

	private bool mIsDebugMode;

	private float destY;

	private float startY;

	private bool started;

	public const float DefaultScrollSpeed = 15f;

	private float animateTimeLimit;

	private float animateTimeCur;

	private float delta;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void InitChatLog()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, S2CChatNtf msg)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void OnMessageClick(S2CChatNtf msg)
	{
	}

	public void OnHeaderClick(S2CChatNtf msg)
	{
	}

	public void ShowFriendInfo(Friend playerInfo, bool inGuildChannel)
	{
	}

	public void ShowFriendAddPopup(Friend f)
	{
	}

	public void OnViewFriendDetail(Friend f)
	{
	}

	private void addFriend(Friend friend)
	{
	}

	public void OnChangeTab(int oldIndex, int newIndex)
	{
	}

	public void RequestChannelChatList()
	{
	}

	public void SendChat(string text)
	{
	}

	public void OnReceiveMsg(S2CChatNtf msg)
	{
	}

	public void OnSendTextClick()
	{
	}

	public void SetList()
	{
	}

	private void RefreshChannelChatFreeTime()
	{
	}

	public void SetUnReadTag()
	{
	}

	private void UpdateContentInUIThread(float moveTime, bool animate)
	{
	}

	private void setPanelOffser(float moveTime, bool animate)
	{
	}

	private void panelPosZero()
	{
	}

	private void animatePanelTo(float y, float timeSecond = -1f)
	{
	}

	private void setPanelPos(Vector3 pos)
	{
	}

	private void Update()
	{
	}
}
