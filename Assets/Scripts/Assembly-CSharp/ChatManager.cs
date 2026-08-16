using System;
using Ice.ProjectCos.Protocol;

public class ChatManager
{
	private static ChatManager instance;

	public Action<S2CChatNtf> E_ReceiveMsg;

	private int RequestWaitingCount;

	public bool IsReceiving { get; private set; }

	public ChatChannel WorldChat { get; private set; }

	public ChatChannel GuildChat { get; private set; }

	private ChatManager()
	{
	}

	public static ChatManager getInstance()
	{
		return null;
	}

	public static void Release()
	{
	}

	public ChatChannel GetChatChannelByType(C2SChatReq.TypeEnum type)
	{
		return null;
	}

	private void BeginReceiveChat()
	{
	}

	private void EndReceiveChat()
	{
	}

	public void OnReceiveChatMsg(object obj, int msgId)
	{
	}

	public void LoadFromProto(ChatProto chatInfo)
	{
	}
}
