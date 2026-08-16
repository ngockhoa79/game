using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class SdkManager : MonoBehaviour
{
	public enum LoginState
	{
		Success = 0,
		NoPermission = 1,
		SiganatureInvalid = 2,
		TimeOut = 3,
		GSS_AppidNotExist = 4,
		PlatformIdNotExist = 5,
		NoSupportPayment = 6,
		ServiceError = 9,
		SessionCheckFailed = 20126,
		ParamNotComplete = 10112
	}

	[CompilerGenerated]
	private sealed class _003CReq_Access_token_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string param;

		public SdkManager _003C_003E4__this;

		private WWW _003CgetData_003E5__2;

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
		public _003CReq_Access_token_003Ed__25(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CReq_UserInfo_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string access_token;

		public string openid;

		public SdkManager _003C_003E4__this;

		private WWW _003CgetUserInfo_003E5__2;

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
		public _003CReq_UserInfo_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CInternalPhoneGetBound_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string phone;

		public string Token;

		public SdkManager _003C_003E4__this;

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
		public _003CInternalPhoneGetBound_003Ed__28(int _003C_003E1__state)
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

	public Action<string> E_OnLoginSuccess;

	public Action<LoginState> E_OnLoginFailed;

	public Action E_OnLogout;

	public Action E_OnBindMobile;

	public string CustomServiceUrl;

	public bool bShowUserCenter;

	public static string unionid;

	public void didLoginCallback(string result)
	{
	}

	public void didLogoutCallback()
	{
	}

	public void didLoginFailed()
	{
	}

	public void didPaymentSuccess(string result)
	{
	}

	public void didPaymentFail(string result)
	{
	}

	public void didCloseLoginViewWithType(string viewName)
	{
	}

	public void showBlock()
	{
	}

	public void hideBlock()
	{
	}

	public void showUserCenterResult(string platformId)
	{
	}

	public void onGetBulletinSuccessWithResult(string result)
	{
	}

	public void onGetBulletinFailed()
	{
	}

	public void onAndroidBack()
	{
	}

	public void BindMobile()
	{
	}

	public void WeiXinloginCallBack(string param)
	{
	}

	public void QQloginCallBack(string param, bool FastLogin = false)
	{
	}

	public void PhoneloginCallBack(string param, bool FastLogin = false)
	{
	}

	public static void PushValue(ref string kUrl, string kKey, string kValue)
	{
	}

	[IteratorStateMachine(typeof(_003CReq_Access_token_003Ed__25))]
	private IEnumerator Req_Access_token(string param)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReq_UserInfo_003Ed__26))]
	private IEnumerator Req_UserInfo(string access_token, string openid)
	{
		return null;
	}

	public void phoneGetBound(string phone, string Token)
	{
	}

	[IteratorStateMachine(typeof(_003CInternalPhoneGetBound_003Ed__28))]
	public IEnumerator InternalPhoneGetBound(string phone, string Token)
	{
		return null;
	}
}
