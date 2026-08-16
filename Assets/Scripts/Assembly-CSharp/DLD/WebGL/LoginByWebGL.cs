using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MYTOOL.Event;
using MYTOOL.Http;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace DLD.WebGL
{
	public class LoginByWebGL : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSliderTipsProgress_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoginByWebGL _003C_003E4__this;

			public float interval;

			private int _003CtipsCount_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CSliderTipsProgress_003Ed__43(int _003C_003E1__state)
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
		private sealed class _003CSliderProgress_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoginByWebGL _003C_003E4__this;

			public float initValue;

			public float totalTime;

			private float _003CelapsedTime_003E5__2;

			private float _003CremainingTotalTime_003E5__3;

			private float _003CremainingTime_003E5__4;

			private float _003CstartProgress_003E5__5;

			private float _003CnewElapsed_003E5__6;

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
			public _003CSliderProgress_003Ed__46(int _003C_003E1__state)
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
		private sealed class _003CWxOrQQLogin_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string account;

			public string password;

			public string loginType;

			public LoginByWebGL _003C_003E4__this;

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
			public _003CWxOrQQLogin_003Ed__70(int _003C_003E1__state)
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

		public static LoginByWebGL ins;

		public GameObject frameRoot;

		public GameObject root1;

		public GameObject root2;

		[Header("NGUI")]
		public GameObject btnEnterGame;

		public GameObject ServerInfoSelector;

		[Header("UGUI")]
		public Toggle toggle1;

		public Toggle toggle2;

		public InputField InputPhone;

		public InputField InputCode;

		public InputField InputAccount;

		public InputField InputPassword;

		public Toggle rememberToggle;

		public Button btnSend;

		public Text textSend;

		public Button btnWXLogin;

		public Button btnQQLogin;

		public Button btnLogin;

		public Button btnLogout;

		public GameObject sliderRoot;

		public Image sliderImg;

		public Text sliderTipsText;

		public Text sliderTipsText2;

		private bool isSendCode;

		private string phone;

		private bool canEnterGame;

		private int loginType;

		private const float _sendInterval = 30f;

		private const string key_last_login_type = "key_last_login_type_1";

		private const string key_phone = "key_dld_phone_1";

		private const string key_token = "key_dld_token_1";

		private const string key_saved_account = "SavedAccount";

		private const string key_saved_password = "SavedPassword";

		private const string key_last_account_login_type = "key_account_login_type";

		private int lastValue;

		private bool isInitFinish;

		private float tTime;

		public static bool CanLogin => false;

		public static bool CanRegister => false;

		public static int LoginType => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void TwoStep()
		{
		}

		[IteratorStateMachine(typeof(_003CSliderTipsProgress_003Ed__43))]
		private IEnumerator SliderTipsProgress(float interval)
		{
			return null;
		}

		private string GetTipsContent(int maxValue)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSliderProgress_003Ed__46))]
		private IEnumerator SliderProgress(float totalTime, float initValue)
		{
			return null;
		}

		private void OnHandleMessage(IEventMessage message)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnToggleValueChange(bool value)
		{
		}

		private void OnToggleValueChange2(bool value)
		{
		}

		private void Load(out string phone, out string token)
		{
			phone = null;
			token = null;
		}

		private void LoadAccountAndPassword(out string account, out string password)
		{
			account = null;
			password = null;
		}

		private void SaveAccountAndPassword(string account, string password, string loginType)
		{
		}

		private void Save(string phone, string token)
		{
		}

		private void Update()
		{
		}

		private void OnInputValueChanged(string newValue)
		{
		}

		private void OnClickSend()
		{
		}

		private void OnClickLogout()
		{
		}

		private void OnClickLogin()
		{
		}

		private void PostSendSms(string phone)
		{
		}

		private void OnSendSmsCallback(HttpRequest request, HttpResponse response)
		{
		}

		private void PostCheckSms(string phone, string code)
		{
		}

		private void OnCheckSmsCallback(HttpRequest request, HttpResponse response)
		{
		}

		private void GoGame(string phone, string token)
		{
		}

		private void GoGame()
		{
		}

		private void OnClickWXLogin()
		{
		}

		private void OnClickQQLogin()
		{
		}

		[IteratorStateMachine(typeof(_003CWxOrQQLogin_003Ed__70))]
		private IEnumerator WxOrQQLogin(string account, string password, string loginType)
		{
			return null;
		}
	}
}
