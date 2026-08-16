using System.Collections.Generic;
using UnityEngine;

public class UIOpActivityNotification : MonoBehaviour
{
	private enum EState
	{
		None = 0,
		Delay = 1,
		Move = 2
	}

	[SerializeField]
	private UILabel lbSampleLabel;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float intervalTime;

	private bool bStart;

	private int curIndex;

	private float delayTime;

	private List<string> _notifications;

	private List<UILabel> allLabels;

	private EState state;

	private void Awake()
	{
	}

	public void SetData(List<string> notifications)
	{
	}

	public void AddData(string notifyString)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private bool _check_all_label_()
	{
		return false;
	}

	private void _move_()
	{
	}

	private void _create_label_()
	{
	}

	private void _clean_all_labels()
	{
	}
}
