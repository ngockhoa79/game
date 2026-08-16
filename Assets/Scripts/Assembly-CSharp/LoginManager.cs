using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class LoginManager : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CPhoneLogin_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string Url;

		public LoginManager _003C_003E4__this;

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
		public _003CPhoneLogin_003Ed__32(int _003C_003E1__state)
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

	public UIInput UsernameInput;

	public UILoginServerRoot loginServerRoot;

	public UILabel lbAreaId;

	public UILabel lbAreaName;

	public UIEventListener btnLogout;

	public UIEventListener btnRealmSelector;

	public UIEventListener btnEnterGame;

	public UIEventListener btnLoginWx;

	public UIEventListener btnLoginQQ;

	public UIEventListener btnLoginIOS;

	public UIEventListener btnLoginGuest;

	public UIEventListener btnSdkLogin;

	public UIEventListener btnTapLogin;

	public UIEventListener btnFaseLogin;

	public UIEventListener btnRigester;

	public UIEventListener btnAgreement;

	public UIEventListener btnAgree;

	public UIEventListener btn16Add;

	public UIEventListener btnAgreement1;

	public UIEventListener btnAgree1;

	public UIEventListener btnAgree2;

	public UIEventListener AccountLogin;

	public UIToggle GuidanceChoose;

	public GameObject right;

	public GameObject AgreeMent16Add;

	public GameObject agreePanel;

	public Action E_OnLogout;

	public Action E_OnRealmSelector;

	public Action E_OnEnterGame;

	protected override void DoInit()
	{
	}

	public void OnGundanceValeChange()
	{
	}

	protected override void DoPrepare()
	{
		if (btnEnterGame != null)
		{
			UIEventListener.Get(btnEnterGame.gameObject).onClick = (go) =>
			{
				UnityEngine.Debug.Log("[LOGIN-UI] btnEnterGame clicked!");
				if (E_OnEnterGame != null)
				{
					E_OnEnterGame.Invoke();
				}
			};
		}
		if (btnLogout != null)
		{
			UIEventListener.Get(btnLogout.gameObject).onClick = (go) =>
			{
				UnityEngine.Debug.Log("[LOGIN-UI] btnLogout clicked!");
				if (E_OnLogout != null)
				{
					E_OnLogout.Invoke();
				}
			};
		}
		if (btnRealmSelector != null)
		{
			UIEventListener.Get(btnRealmSelector.gameObject).onClick = (go) =>
			{
				UnityEngine.Debug.Log("[LOGIN-UI] btnRealmSelector clicked!");
				if (E_OnRealmSelector != null)
				{
					E_OnRealmSelector.Invoke();
				}
			};
		}
	}

	[IteratorStateMachine(typeof(_003CPhoneLogin_003Ed__32))]
	private IEnumerator PhoneLogin(string Url)
	{
		return null;
	}

	private void Regiester(GameObject obj)
	{
	}

	private void ShowAccountLogInPanel(GameObject obj)
	{
	}

	public void RefreshView()
	{
	}

	private void GetMd5Code(GameObject obj)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void EditorLoginSuccess()
	{
	}

	public void GuestLoginSuccess()
	{
	}

	public void CYLoginSuccess()
	{
	}

	public void CYLogining()
	{
	}

	private void readPrefs(out string username)
	{
		username = null;
	}

	public void savePrefs(string username)
	{
	}

	private void Start()
	{
	}

	public void OnApplicationQuit()
	{
	}
}
