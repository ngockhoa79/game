using System;
using UnityEngine;

public class Result_PVP_RecordBreak_Ctrller : MonoBehaviour
{
	public UILabel historyTopOrder;

	public UILabel currentOrder;

	public Transform upRoot;

	public UILabel upLabel;

	public GameObject rewardRoot;

	public UniIcon reputationIcon;

	public UniIcon crystalIcon;

	public UIEventListener confirmBtn;

	public IceAnimatorTotalCommander anim_in;

	private Action onClose;

	public void SetData(Action _onClose)
	{
	}

	private void ClosePanel(GameObject _object)
	{
	}
}
