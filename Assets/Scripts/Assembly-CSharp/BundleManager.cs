using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Foundation;
using Ice.Client;
using UnityEngine;

public class BundleManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoLoadOneBundleInternal_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool bForceFromUrl;

		public BundleManager _003C_003E4__this;

		public string bundleName;

		public string loadResourceType;

		public Action<bool> callback;

		private bool _003CloadFromUrl_003E5__2;

		private string _003CrelatedPath_003E5__3;

		private string _003Curl_003E5__4;

		private int _003CtryNum_003E5__5;

		private bool _003CisDone_003E5__6;

		private WWW _003Cwww_003E5__7;

		private AssetBundleCreateRequest _003CthisAbRequest_003E5__8;

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
		public _003CDoLoadOneBundleInternal_003Ed__1(int _003C_003E1__state)
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
	private sealed class _003CDoLoadOneJpgAsync_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string loadResourceType;

		public string bundleName;

		public Action<bool> callback;

		public BundleManager _003C_003E4__this;

		public bool bForceFromUrl;

		private BuildTargetContent _003CbuildConfig_003E5__2;

		private bool _003Cresult_003E5__3;

		private string _003Curl_003E5__4;

		private WWW _003Cwww_003E5__5;

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
		public _003CDoLoadOneJpgAsync_003Ed__2(int _003C_003E1__state)
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
	private sealed class _003CDoLoadOneJpgFromUrlInternal_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string loadResourceType;

		public string bundleName;

		public Action<bool> callback;

		public BundleManager _003C_003E4__this;

		private BuildTargetContent _003CbuildConfig_003E5__2;

		private int _003CtryNum_003E5__3;

		private bool _003CisDone_003E5__4;

		private string _003CrelatedPath_003E5__5;

		private string _003Curl_003E5__6;

		private WWW _003Cwww_003E5__7;

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
		public _003CDoLoadOneJpgFromUrlInternal_003Ed__3(int _003C_003E1__state)
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

	private DuplicationContainerObject resourceObjects;

	private AssetBundlePackage m_mAllBundles;

	private DuplicationContainerTexture _jpgContainer;

	public const string BUND_VERSION = "version";

	public const string BUND_GAMCONFIG = "GameConfig";

	public AssetBundlePackage AllBundles => null;

	public event Action<string, string, bool> E_OnBundleLoadComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void DoLoadOneBundleSync(string loadResourceType, string bundleName, bool bForceFromUrl, Action<bool> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CDoLoadOneBundleInternal_003Ed__1))]
	private IEnumerator DoLoadOneBundleInternal(string loadResourceType, string bundleName, bool bForceFromUrl, Action<bool> callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoLoadOneJpgAsync_003Ed__2))]
	private IEnumerator DoLoadOneJpgAsync(string loadResourceType, string bundleName, bool bForceFromUrl, Action<bool> callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoLoadOneJpgFromUrlInternal_003Ed__3))]
	private IEnumerator DoLoadOneJpgFromUrlInternal(string loadResourceType, string bundleName, Action<bool> callback)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public T LoadSpecificResource<T>(string bundleName, string loadResourceType) where T : UnityEngine.Object
	{
		return null;
	}

	public void SetUITexture(UITexture texture, string resType, string bundleName, Action callback = null)
	{
	}

	public void SetUITextureNew1(UITexture texture, string resType, string bundleName, Action callback = null)
	{
	}

	public void SetUITextureNew(UITexture texture, string bundleName, Action callback = null)
	{
	}

	public void LoadAndGetObjectSync<T>(string loadResourceType, string bundleName, Action<string, string, UnityEngine.Object> callback) where T : UnityEngine.Object
	{
	}

	public void LoadAndGetObjectSync<T>(string loadResourceType, string bundleName, Action<UnityEngine.Object> callback) where T : UnityEngine.Object
	{
	}

	private void LoadAndGetObjectInternal<T>(string loadResourceType, string bundleName, Action<UnityEngine.Object> callback) where T : UnityEngine.Object
	{
	}

	public Texture TryGetTextureFromBundle(string loadResourceType, string bundleName)
	{
		return null;
	}

	public bool UnloadBundle(string bundleName, string loadResourceType, bool unloadAll = false)
	{
		return false;
	}

	public void UnloadAllBundles(bool unloadAllBundles = false)
	{
	}

	public float GetLoadPercent(string loadResourceType, string bundleName)
	{
		return 0f;
	}

	private Texture2D create_tex_from_buff(BuildTargetContent buildTarget, byte[] buff)
	{
		return null;
	}

	private void OnBundleLoadComplete(string loadResourceType, string bundleName, AssetBundle ab = null)
	{
	}

	private void OnJpgLoadComplete(string loadResourceType, string bundlename, Texture tex = null)
	{
	}

	private string GetBundleUrl(string bundlename, string loadResourceType, out string relatedPath, out bool loadFromUrl)
	{
		relatedPath = null;
		loadFromUrl = default(bool);
		return null;
	}

	public string GetRemoteUrl(string bundlename, string loadResourceType, out string relatedPath)
	{
		relatedPath = null;
		return null;
	}

	public void DoLoadBundleList(Dictionary<string, List<string>> bundlesDic, Action onCallback)
	{
	}

	private string GetBundleFilename(string bundlename, string loadResourceType)
	{
		return null;
	}

	public void BackupObjectFromBundle(string loadResourceType, string bundlename)
	{
	}

	public UnityEngine.Object TryGetFromBackup(string loadResourceType, string bundlename)
	{
		return null;
	}

	public void ClearBackup()
	{
	}

	public void ClearBackupExcept(List<BattleResourceItem> exceptList)
	{
	}
}
