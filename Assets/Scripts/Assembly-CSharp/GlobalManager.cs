using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.Project.Utils;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

[AddComponentMenu("ICEE/Globals")]
public class GlobalManager : MonoBehaviour
{
	public enum UserState
	{
		Login = 0,
		InGuidance = 1,
		InGame = 2
	}

	[CompilerGenerated]
	private sealed class _003CInitialQuene_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GlobalManager _003C_003E4__this;

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
		public _003CInitialQuene_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CRelogIn_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GlobalManager _003C_003E4__this;

		public string tk;

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
		public _003CRelogIn_003Ed__110(int _003C_003E1__state)
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
	private sealed class _003CGetBound_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string Token;

		public string Logintype;

		private WWW _003Cret_003E5__2;

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
		public _003CGetBound_003Ed__113(int _003C_003E1__state)
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
	private sealed class _003CGetClientVersioninfo_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string SdkId;

		private WWW _003Cret_003E5__2;

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
		public _003CGetClientVersioninfo_003Ed__116(int _003C_003E1__state)
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

	private string mHeadUrl;

	private string _version_title;

	private string _version_sub;

	public bool UnderGuidance;

	public bool BinPlayed;

	[HideInInspector]
	public bool WebGLFirstLogin;

	public UserState CurState;

	public Canvas UGUICanvas;

	private static GlobalManager ms_instance;

	private ApplicationManager m_ApplicationManager;

	private BundleManager m_BundleManager;

	private DownloadManager m_DownloadManager;

	private ResourcesManager m_ResourcesManager;
	// [RECOVERED]
	public ResourcesManager ResourcesManager => m_ResourcesManager;

	private NetManager m_NetManager;

	private BattleReportM m_BattleReportManager;

	private SceneManager m_SceneManager;

	private LoadingUI m_LoadingUI;

	private AudioManager m_AudioManager;

	private FloatingBoardManager m_FloatingBoardManager;

	private RecordReplayManager m_RecordReplayManager;

	private AudioDownloadManager m_AudioDownloadManager;

	private TimerManager m_TimerManager;

	private ItemAtlasManager m_ItemAtlasManager;

	private SweepManager m_SweepManager;

	private TouchManager m_TouchManager;

	private GainItemPopManager m_GainItemPopManager;

	private SdkManager m_SdkManager;

	private Squander m_Squander;

	private bool _initialized;

	private TipManager mTipManager;

	private DailyTimerTrigger dailyTimer;

	private SampleConcurrentQueue<Action> actionQueue_;

	public string HeadUrl => null;

	public string version_title => null;

	public string version_sub => null;

	public string ServerVersion => null;

	public static GlobalManager Instance
	{
		get
		{
			if (ms_instance == null)
			{
				ms_instance = UnityEngine.Object.FindObjectOfType<GlobalManager>();
				if (ms_instance == null)
				{
					GameObject gameObject = new GameObject("GlobalManager");
					if (Application.isPlaying)
					{
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
					}
					ms_instance = gameObject.AddComponent<GlobalManager>();
				}
			}
			return ms_instance;
		}
	}

	public ApplicationManager ApplicationManager => null;

	public BundleManager BundleManager => null;

	public DownloadManager DownloadManager
	{
		get
		{
			if (m_DownloadManager == null)
			{
				m_DownloadManager = GetComponent<DownloadManager>();
				if (m_DownloadManager == null)
				{
					m_DownloadManager = gameObject.AddComponent<DownloadManager>();
				}
			}
			return m_DownloadManager;
		}
	}

	public NetManager NetManager
	{
		get
		{
			if (m_NetManager == null)
			{
				m_NetManager = GetComponent<NetManager>();
				if (m_NetManager == null)
				{
					m_NetManager = gameObject.AddComponent<NetManager>();
				}
			}
			return m_NetManager;
		}
	}

	public BattleReportM BattleReportManager => null;

	public SceneManager SceneManager
	{
		get
		{
			if (m_SceneManager == null)
			{
				m_SceneManager = GetComponent<SceneManager>();
				if (m_SceneManager == null)
				{
					m_SceneManager = gameObject.AddComponent<SceneManager>();
				}
			}
			return m_SceneManager;
		}
	}

	public LoadingUI LoadingUI => null;

	public AudioManager AudioManager => null;

	public FloatingBoardManager FloatingBoardManager
	{
		get
		{
			if (m_FloatingBoardManager == null)
			{
				m_FloatingBoardManager = GetComponent<FloatingBoardManager>();
				if (m_FloatingBoardManager == null)
				{
					m_FloatingBoardManager = gameObject.AddComponent<FloatingBoardManager>();
				}
			}
			return m_FloatingBoardManager;
		}
	}

	public RecordReplayManager RecordReplayManager => null;

	public AudioDownloadManager AudioDownloadManager => null;

	public TimerManager TimerManager => null;

	public ItemAtlasManager ItemAtlasManager => null;

	public SweepManager SweepManager => null;

	public TouchManager TouchManager => null;

	public GainItemPopManager GainItemPopManager => null;

	public SdkManager SdkManager => null;

	public bool Initialized => false;

	public TipManager TipManager => null;

	private void Awake()
	{
		if (ms_instance == null)
		{
			ms_instance = this;
			if (Application.isPlaying)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			if (actionQueue_ == null)
			{
				actionQueue_ = new SampleConcurrentQueue<Action>();
			}
			InitilizeComponents();
			_initialized = true;
			ActivateDailyTimer();
			UnityEngine.Debug.Log("[GLOBAL] GlobalManager initialized in Awake");
		}
		else if (ms_instance != this)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		RunActionQueue();
	}

	private void wbcQuit(string wbc)
	{
	}

	private void GetLastLoiginServer()
	{
	}

	public void ExitScene()
	{
	}

	private void InitilizeComponents()
	{
		if (m_ApplicationManager == null)
		{
			m_ApplicationManager = GetComponent<ApplicationManager>();
			if (m_ApplicationManager == null)
			{
				m_ApplicationManager = gameObject.AddComponent<ApplicationManager>();
			}
		}
		if (m_NetManager == null)
		{
			m_NetManager = GetComponent<NetManager>();
			if (m_NetManager == null)
			{
				m_NetManager = gameObject.AddComponent<NetManager>();
			}
		}
		if (m_SceneManager == null)
		{
			m_SceneManager = GetComponent<SceneManager>();
			if (m_SceneManager == null)
			{
				m_SceneManager = gameObject.AddComponent<SceneManager>();
			}
		}
	}

	[IteratorStateMachine(typeof(_003CInitialQuene_003Ed__24))]
	private IEnumerator InitialQuene()
	{
		return null;
	}

	private object InitializeForm(string _ManagerName)
	{
		return null;
	}

	private void OnApplicationQuit()
	{
	}

	public void UserLogin()
	{
		UnityEngine.Debug.Log("[STATE] GlobalManager.UserLogin() called — transitioning CurState to UserState.InGame");
		if (Me.Ins != null)
		{
			Me.Ins.UserLogin();
		}
		CurState = UserState.InGame;
		UnityEngine.Debug.Log($"[STATE] GlobalManager.CurState is now {CurState}");
	}

	public void UserLogout()
	{
	}

	public void ActiveFromBackground()
	{
	}

	private void OnDay0Clock()
	{
	}

	private void OnDay4Clock()
	{
	}

	private void OnDay18Clock()
	{
	}

	private void OnDay19Clock()
	{
	}

	public void Post(Action action)
	{
	}

	private void RunActionQueue()
	{
	}

	private void ActivateDailyTimer()
	{
	}

	public void FastLogInCB(string s)
	{
	}

	public void QQLoginCB(string s)
	{
	}

	public void WXLoginCB(string s)
	{
	}

	public void AccountLogInCB(string s)
	{
	}

	public void BindMobileCB(string code)
	{
	}

	public void LogOut(string l)
	{
	}

	public void SwitchAccount(string l)
	{
	}

	[IteratorStateMachine(typeof(_003CRelogIn_003Ed__110))]
	private IEnumerator RelogIn(string tk)
	{
		return null;
	}

	public void phoneVerifyBind(string phone, string Token)
	{
	}

	public void verifyBind(string token, string LogInType)
	{
	}

	[IteratorStateMachine(typeof(_003CGetBound_003Ed__113))]
	public IEnumerator GetBound(string Token, string Logintype)
	{
		return null;
	}

	public void InterfaceGetVersion(string sdkID)
	{
	}

	public void CheckClientVersion()
	{
	}

	[IteratorStateMachine(typeof(_003CGetClientVersioninfo_003Ed__116))]
	private IEnumerator GetClientVersioninfo(string SdkId)
	{
		return null;
	}
}
