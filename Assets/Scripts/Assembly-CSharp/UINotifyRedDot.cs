using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UINotifyRedDot : MonoBehaviour
{
	private List<INotifyEvent> customEvents;

	public List<NotifyType> NotifyTypes;

	public GameObject RedDot;

	private bool mInited;

	private void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void OnChange()
	{
	}

	private void OnDestroy()
	{
	}

	public void UnregisterCustomAction()
	{
	}

	public void RegisterCustomAction(INotifyEvent _customEvent)
	{
	}
}
