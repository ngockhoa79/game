using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISmeltJourneryMap : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CSetStages_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISmeltJourneryMap _003C_003E4__this;

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
		public _003CSetStages_003Ed__28(int _003C_003E1__state)
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

	public UIEventListener BtnHome;

	public UIEventListener BtnBack;

	public UIEventListener BtnRank;

	public UIEventListener BtnReport;

	public UIEventListener BtnExchange;

	public UIEventListener BtnHelp;

	public UIEventListener BtnSweep;

	public Action OnHome;

	public Action OnBack;

	public Action OnRank;

	public Action OnReport;

	public Action OnExchange;

	public Action<Transform> OnHelp;

	public Action<int> OnKick;

	public Action<int> OnObtain;

	public GameObject DragStageList;

	public UISJMapStageDisplayer[] Stages;

	public UISJMapBossDisplayer[] Bosses;

	public UILabel lblSilver;

	public UILabel lblGolden;

	public UILabel lblCoin;

	public UILabel lblCrystal;

	public UILabel lblGold;

	[SerializeField]
	private UINotificationAttacher notificationAttacher;

	public void SetData()
	{
	}

	private void check()
	{
	}

	public void ClearStage(int index, bool isManito = false)
	{
	}

	public void SweepStages(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CSetStages_003Ed__28))]
	private IEnumerator SetStages(int index)
	{
		return null;
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void UpdateStageS()
	{
	}

	protected override void DoInit()
	{
	}

	public int GetAddedTrialCoins(S2CTrialOneKeyStartBattleAck ack)
	{
		return 0;
	}

	protected override void DoDispose()
	{
	}

	private void ShowMyReport()
	{
	}

	private void ClearReport()
	{
	}

	private void UpdateGold(int newValue)
	{
	}

	private void UpdateCoin(int newValue)
	{
	}

	private void UpdateCrystal(int newValue)
	{
	}
}
