using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIActivityChoose : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003C_internal_play_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int index;

		public UIActivityChoose _003C_003E4__this;

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
		public _003C_internal_play_003Ed__35(int _003C_003E1__state)
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

	public UIEventListener eventHome;

	public UIEventListener eventReturn;

	public Transform[] LevelPostions;

	private List<ItemActivityChapter> mLoadChaperItems;

	public UpdateTimerUTC TimerAutoRefresh;

	public UILabel lbNPCText;

	public GameObject NPCText;

	public GameObject NPC;

	public IceAnimatorTotalCommander AnimateAwardNPC;

	[SerializeField]
	private UINotificationAttacher notificationAttacher;

	private bool mAnimateComplete;

	private bool mEnded;

	private int mLastIndex;

	public int SelectChapterID { get; set; }

	public int SelectLevelID { get; set; }

	public bool PlayAnimation { get; set; }

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void TimerBegin()
	{
	}

	private void timeSetNext()
	{
	}

	public void OnOpenDialogActivityChapter(ActivityChapter ac)
	{
	}

	private void OnChallageLevel(ActivityChapter ac, ActivityLevel aLv, int idx)
	{
	}

	public void LoadAllChapter()
	{
	}

	[IteratorStateMachine(typeof(_003C_internal_play_003Ed__35))]
	private IEnumerator _internal_play(int index)
	{
		return null;
	}

	public void PlayChapterAnimationAll()
	{
	}

	public void PlayChapterAnimation1by1(int index)
	{
	}

	private void onEndChapterAnimation()
	{
	}

	private void showBuyChallegeDialog(ActivityChapter ac, int levelID)
	{
	}

	private void bugChallageTime(ActivityChapter ac, int levelID)
	{
	}

	private void showRadomNPCText()
	{
	}

	private void hideGreatAwardNPCText()
	{
	}

	public void ActivateNPC(bool isShow)
	{
	}

	public void RequestLofftery(ActivityChapter ac, ActivityLevel level)
	{
	}
}
