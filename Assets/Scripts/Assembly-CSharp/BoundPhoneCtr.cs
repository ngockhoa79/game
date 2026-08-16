using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class BoundPhoneCtr : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRequestWeb_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoundPhoneCtr _003C_003E4__this;

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
		public _003CRequestWeb_003Ed__25(int _003C_003E1__state)
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

	public UIEventListener ConfirmBtn;

	public UIEventListener CancelBtn;

	public UIEventListener GetcodeBtn;

	public UIEventListener Notices;

	public UIEventListener BGCLider;

	public UIInput PhoneNum;

	public UIInput Token;

	public UIInput PassWord;

	public GameObject NoticesPanel;

	private string phone;

	public static Action<string> Back;

	private string logintype;

	private int time;

	public const string Accode = "cfc0c0c8aca435b2eeaa78fb19808071";

	public const bool ForbitCharge = false;

	public static Action BindCallbackAc;

	public const bool X20 = false;

	public const bool IsJianWan = false;

	private void Start()
	{
	}

	private void Confirm(GameObject obj)
	{
	}

	private void Cancel(GameObject obj)
	{
	}

	private void GetCode(GameObject obj)
	{
	}

	private void MinumCount()
	{
	}

	private void BindCallBack(string value)
	{
	}

	private void ResetGetCodeBtn()
	{
	}

	[IteratorStateMachine(typeof(_003CRequestWeb_003Ed__25))]
	private IEnumerator RequestWeb()
	{
		return null;
	}

	public static string GetMd5Str1(string password)
	{
		return null;
	}

	public static bool ContainChinese(string input)
	{
		return false;
	}

	public static bool ContainSymbol(string input)
	{
		return false;
	}

	private bool CheckPhoneIsAble(string input)
	{
		return false;
	}
}
