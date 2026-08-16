using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class ItemChatGroup : MonoBehaviour
{
	public ItemChat ItemNormal;

	public ItemChat ItemMe;

	public ItemChat ItemSys;

	public void SetData(S2CChatNtf msg, Action<S2CChatNtf> onHeaderClick = null, Action<S2CChatNtf> onMessageClick = null)
	{
	}
}
