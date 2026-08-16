using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UINotification : IceUIBase
{
	public enum ENotificationType
	{
		MainSceneNotification = 0,
		ConvoyNotification = 1,
		SmeltJourney = 2
	}

	private enum EState
	{
		None = 0,
		Wait = 1
	}

	[SerializeField]
	private UILabel sample;

	[SerializeField]
	private ENotificationType notifyType;

	[SerializeField]
	private IceAnimatorTotalCommander anim_enter;

	public GameObject goBackground;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	private float IntervalWaitSeconds;

	private List<Notifications.AnnouncementStruct> _dataList;

	private int nextIndex;

	private bool _bRunInBackground;

	private Notifications.AnnouncementStruct backgroundLastContent;

	public bool showingMessage;

	private EState _state;

	private float waitedTime;

	public bool RunInBackground
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	private void StartShowNotifications()
	{
	}

	private void ShowNextNotification()
	{
	}

	private void ShowThisNotification(Notifications.AnnouncementStruct announcement)
	{
	}

	private void ReadFromDataModel()
	{
	}

	public int GetNotificationCount()
	{
		return 0;
	}

	private string ConvertToString(AnnouncementItemProto itemProto)
	{
		return null;
	}
}
