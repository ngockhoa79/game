using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIOpActivityYingCaiShen : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003Cwait_animation_stop_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIOpActivityYingCaiShen _003C_003E4__this;

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
		public _003Cwait_animation_stop_003Ed__27(int _003C_003E1__state)
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
	private IceAnimatorTotalCommander anim_start;

	[SerializeField]
	private IceAnimatorTotalCommander anim_stop;

	[SerializeField]
	private UIEventListener btnSlotMachine;

	[SerializeField]
	private UIEventListener btnAddCrystal;

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UIButton buttonSlotMachine;

	[SerializeField]
	private UIOpActivityNumCtrller numCtrller;

	[SerializeField]
	private UILabel lbConsume;

	[SerializeField]
	private UIOpActivityTimerDowncounter downCounter;

	[SerializeField]
	private UIOpActivityNotification notification;

	[SerializeField]
	private UILabel lbChance;

	[SerializeField]
	private UILabel lbMaxRatio;

	[SerializeField]
	private float timeWait;

	private List<int> moneyList;

	private int curIndex;

	private bool isAnimating;

	private DateTime startTime;

	private DateTime endTime;

	private int ___gain;

	protected override void DoPrepare()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void _bind_widget_event_()
	{
	}

	private void _refresh_widget_()
	{
	}

	private void _send_info_op_()
	{
	}

	private void _playanimation_(int lost, int gain)
	{
	}

	[IteratorStateMachine(typeof(_003Cwait_animation_stop_003Ed__27))]
	private IEnumerator wait_animation_stop()
	{
		return null;
	}

	private void _stop_animation_()
	{
	}

	private void _set_button_state_(int val, bool bEnable)
	{
	}

	private void _refresh_notifications_(List<SlotMachineInfoProto.RecordProto> data)
	{
	}

	private void _refresh_chance_()
	{
	}
}
