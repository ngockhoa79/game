using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class UISystemSettings : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CGetAgreement_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISystemSettings _003C_003E4__this;

		private UnityWebRequest _003Cret_003E5__2;

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
		public _003CGetAgreement_003Ed__51(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetPrivacy_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISystemSettings _003C_003E4__this;

		private UnityWebRequest _003Cret_003E5__2;

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
		public _003CGetPrivacy_003Ed__52(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public UIEventListener btnClose;

	public UIEventListener btnAbout;

	public UIEventListener btnPrivate;

	public UIEventListener btnCloseAbout;

	public UIEventListener btnClosePrivate;

	public UIEventListener btnCloseDetail;

	public UIEventListener btnCloseRevoke;

	public UIEventListener btnUser;

	public UIEventListener btnProtect;

	public UIEventListener btnRevoke;

	public UIEventListener btnRevokeYes;

	public UIEventListener btnRevokeNo;

	public UISwitch btnSound;

	public UISwitch btnBgm;

	public UISwitch btnBulletin;

	public UISwitch btnGet12Stamina;

	public UISwitch btnGet18Stamina;

	public UISwitch btnFullStamina;

	public UISwitch btnHongBao;

	public UISwitch btnConvoy;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public GameObject panelSetting;

	public GameObject panelAbout;

	public GameObject panelPrivate;

	public GameObject panelDetail;

	public GameObject panelRevoke;

	public GameObject scroll1;

	public GameObject scroll2;

	public UILabel lbContent;

	public UILabel lbContent2;

	public UILabel lbVersion;

	public UILabel lbEmail;

	private bool bSound;

	private bool bBGM;

	private bool bGet12Stamina;

	private bool bGet18Stamina;

	private bool bFullStamina;

	private bool bHongBao;

	private bool bConvoy;

	public Action E_OnClose;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void Initial()
	{
	}

	private void Hook()
	{
	}

	private void Dehook()
	{
	}

	public void OnBulletinSettingChanged(bool pre_state, bool cur_state)
	{
	}

	[IteratorStateMachine(typeof(_003CGetAgreement_003Ed__51))]
	private IEnumerator GetAgreement()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetPrivacy_003Ed__52))]
	private IEnumerator GetPrivacy()
	{
		return null;
	}
}
