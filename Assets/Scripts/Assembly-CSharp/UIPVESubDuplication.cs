using System;
using System.Collections.Generic;
using UnityEngine;

public class UIPVESubDuplication : MonoBehaviour
{
	public delegate void H_OnClickedDelegate(int chapterId);

	public delegate void UnlockAniEndDelegate();

	private enum EUnlockStatus
	{
		None = 0,
		Started = 1,
		Closed = 2,
		_NUM = 3
	}

	public H_OnClickedDelegate E_OnClicked;

	public UnlockAniEndDelegate E_UnlockAniEnd;

	public int ChapterId;

	public GameObject image;

	public UIPlaySound soundPlayer;

	public UILabel lbChapterId;

	public UILabel lbWord;

	public GameObject newLabel;

	public GameObject Star1;

	public GameObject Star2;

	public GameObject Star3;

	public UIEventListener btnEvent;

	public Transform parentTransform;

	public Transform airplanePoint;

	public IceAnimatorTotalCommander animator;

	public List<IceAnimatorTotalCommander> activateAnimList;

	public List<IceAnimatorTotalCommander> openAnimList;

	[NonSerialized]
	public UIDragObject dragObj;

	public IceScalingAnimator activeAni;

	public UITexture ItemTexture;

	public UINotifyRedDot RedDotObj;

	private IceAnimatorTotalCommander curActivateAnimator;

	private IceAnimatorTotalCommander curOpenAnimator;

	private bool isLocked;

	private bool bSetValue;

	private string imagePerfix;

	private string imageSuffix;

	private EUnlockStatus mUnlockStatus;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetChapter(int chapterId)
	{
	}

	public void SetLock(bool isLock)
	{
	}

	public void SetData(int starCount, bool bNew, bool bAccessable)
	{
	}

	public void PlayUnlockAni()
	{
	}

	private void UnlockAniClose()
	{
	}

	private void SetStar(int star)
	{
	}

	private void RedDotCheck()
	{
	}
}
