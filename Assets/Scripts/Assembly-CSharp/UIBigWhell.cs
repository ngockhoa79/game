using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIBigWhell : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CwaitSecond_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CwaitSecond_003Ed__73(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private UILabel lbCountGem;

	[SerializeField]
	private UILabel lbPoolMoneyCount;

	[SerializeField]
	private UILabel lbCredit;

	[SerializeField]
	private UICostDisplayer CostRoll;

	[SerializeField]
	private UICostDisplayer CostRoll_10;

	[SerializeField]
	private GameObject goFreeTag;

	[SerializeField]
	private UIEventListener eventHome;

	[SerializeField]
	private UIEventListener eventHelp;

	[SerializeField]
	private UIEventListener eventLottery;

	[SerializeField]
	private UIEventListener eventLottery_10;

	[SerializeField]
	private UIEventListener eventCharge;

	[SerializeField]
	private UIEventListener eventShop;

	private UIButton bnLottery;

	[SerializeField]
	private Transform ContentPos;

	[SerializeField]
	private Transform RollPad;

	[SerializeField]
	private Transform ChangeAngle;

	[SerializeField]
	private UILabel lbAwardText;

	[SerializeField]
	private UIOpActivityNotification TextAnimator;

	[SerializeField]
	private GameObject BigAwardEffect;

	[SerializeField]
	private GameObject WhellPart;

	[SerializeField]
	private UIShopCredit ShopPart;

	public float ChangeAngleTime;

	private List<ThingHolding> mAwards;

	private ProcedureLine mUsingLine;

	private ProcedureManchine mProcduce;

	public float IconScale;

	public float RoundLength;

	public int DevideCount;

	public double RotateSpeed;

	private float EachDegree;

	[SerializeField]
	private UpdateTimerUTC EndTimer;

	[SerializeField]
	private UpdateTimerUTC NextFreeTimer;

	private bool mRolling;

	private int mTurnCount;

	private int mEndCellIndex;

	private float mEndAngleCenter;

	private float mEndAnglePos;

	private float mBeginAngle;

	private float mLastTurnAngle;

	private List<int> mResultIndexs;

	private int mCurShowing;

	public IceAnimatorTotalCommander RollAnimation;

	public IceAnimatorTotalCommander RollFastAnimation;

	private int mBigAward;

	private bool mAnimating;

	private void Start()
	{
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

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void OnChanged(int value)
	{
	}

	public void RequestInfo()
	{
	}

	public void RequestRoll(bool isRoll_10 = false)
	{
	}

	public void setTitle(int value = 0)
	{
	}

	private void createScrollText()
	{
	}

	private void createLine()
	{
	}

	private void openHelpDialong()
	{
	}

	private ThingHolding createAwardThings(int idx)
	{
		return null;
	}

	public void addThings()
	{
	}

	public void RollAnimate1By1(Action onComplete)
	{
	}

	public void RollAnimate(Action onComplete)
	{
	}

	public void RollFastAnimate(Action onComplete)
	{
	}

	public void FakeRoll()
	{
	}

	private void showRollAward()
	{
	}

	private void OnAniStepComplete()
	{
	}

	private void animate_1()
	{
	}

	private void animate_2()
	{
	}

	private void animate_2_2()
	{
	}

	private void animate_3()
	{
	}

	private void animate_4()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitSecond_003Ed__73))]
	private IEnumerator waitSecond(float time)
	{
		return null;
	}

	private string ConvertToString(string name, ThingProto po)
	{
		return null;
	}

	private string ConvertToBigRewardString(string name, ThingProto po)
	{
		return null;
	}

	private void registNTF()
	{
	}

	public void OnServerNTF(object msg, int msgId)
	{
	}

	public void RequestServerEndNTF()
	{
	}

	public static void ShowEndActivityOpDialog()
	{
	}

	public static void ShowNoNetworkOpDialog()
	{
	}

	public void OpenShop()
	{
	}

	public void OpenBigWhell()
	{
	}
}
