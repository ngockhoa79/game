using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class ChatChannel
{
	private List<S2CChatNtf> mChatList;

	private ulong mLastID;

	private DateTime mWorldChatCDTime;

	public C2SChatReq.TypeEnum ChatType { get; private set; }

	public List<S2CChatNtf> ChatList => null;

	public int CacheSize { get; private set; }

	public int FreeSendCount { get; set; }

	public int UnReadCount { get; private set; }

	private ulong LastID => 0uL;

	public DateTime CDTime => default(DateTime);

	public ChatChannel(int cacheSize, C2SChatReq.TypeEnum type)
	{
	}

	public void AddMessage(S2CChatNtf msg)
	{
	}

	public void MarkOffUnReadAll()
	{
	}

	public void SetCDTime(long serverTick)
	{
	}

	public bool IsCDOver()
	{
		return false;
	}

	internal void RequestLastChatList(Action<bool> onReslut)
	{
	}

	public void RequestSendChat(string text, Action<object> onSuccess, Action<object, NetManager.CoreErrorCode> onFail)
	{
	}

	public void RequestGM(string text, Action callBack = null)
	{
	}
}
