using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemFriendGift : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CSetDisplayer_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemFriendGift _003C_003E4__this;

		public int heroId;

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
		public _003CSetDisplayer_003Ed__32(int _003C_003E1__state)
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

	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbTotalBattleValue;

	public UILabel lbGiftProgress;

	public UILabel lbGuildName;

	public GameObject displayerPlaceHolder;

	public UILabel lbGiftLevel;

	public UISprite spProgressMax;

	public UIProgressBarCtrller ProgressBarControlor;

	public UIButton bnSendGift;

	public UIButton bnGetGiftReward;

	public UISprite spDark;

	public UISprite spHighLight;

	public UIEventListener eventItem;

	private GameObject portrait;

	public IceAnimatorTotalCommander AnimationCanAward;

	public Action<Friend, ItemFriendGift> OnSendFriendGift;

	public Action<Friend, ItemFriendGift> OnGetSendGiftReward;

	public Action<Friend, ItemFriendGift> OnItemClick;

	private Friend mFriend;

	public UIAeCardDisplayer CardDisplay;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
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

	public void Clear()
	{
	}

	public Friend GetData()
	{
		return null;
	}

	public void Refresh()
	{
	}

	public void SetData(Friend data)
	{
	}

	[IteratorStateMachine(typeof(_003CSetDisplayer_003Ed__32))]
	private IEnumerator SetDisplayer(int heroId)
	{
		return null;
	}

	public void OnSendGift()
	{
	}

	public void OnSendGiftReward()
	{
	}
}
