using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DownloadManager : MonoBehaviour
{
	private delegate IEnumerator LoadLocalCallBack(WWW www);

	public class DownLoadRecord
	{
		public enum LoadStateEnum
		{
			Preloaded = 0,
			Downloaded = 1,
			NotLoaded = 2
		}

		public static string[] END;

		private char[] SEPERATOR;

		public bool loaded;

		public int loadCount;

		private bool enable;

		private LoadStateEnum loadState;

		private string loadResourceType;

		private string languageVersion;

		private string bundleDirectory;

		private string _filename;

		private string _bundlename;

		private string _bundleList;

		private string version;

		public bool Enable
		{
			get
			{
				return enable;
			}
			set
			{
				enable = value;
			}
		}

		public string Filename => _filename;

		public string Bundlename => _bundlename;

		public string LoadResourceType => loadResourceType;

		public string LanguageVersion => languageVersion;

		public LoadStateEnum LoadState
		{
			get
			{
				return loadState;
			}
			set
			{
				loadState = value;
			}
		}

		public string BundleDirectory => bundleDirectory;

		public string BundleList
		{
			get
			{
				return _bundleList;
			}
			set
			{
				_bundleList = value;
			}
		}

		public string Version
		{
			get
			{
				return version;
			}
			set
			{
				version = value;
			}
		}

		public override string ToString()
		{
			return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", languageVersion, version, loadResourceType, bundleDirectory, _filename, (int)loadState, loaded, loadCount, _bundleList);
		}

		public DownLoadRecord(string s)
		{
			if (SEPERATOR == null)
			{
				SEPERATOR = new char[1] { '\t' };
			}
			if (!string.IsNullOrEmpty(s))
			{
				string[] array = s.Split(SEPERATOR);
				if (array.Length >= 9)
				{
					languageVersion = array[0];
					version = array[1];
					loadResourceType = array[2];
					bundleDirectory = array[3];
					_filename = array[4];
					_bundlename = array[4];
					int result;
					if (int.TryParse(array[5], out result))
					{
						loadState = (LoadStateEnum)result;
					}
					bool.TryParse(array[6], out loaded);
					int.TryParse(array[7], out loadCount);
					_bundleList = array[8];
				}
			}
		}

		public DownLoadRecord(string languageVersion, string version, string loadResourceType, string bundleDirectory, string filename, LoadStateEnum loadState, bool loaded, int loadCount, string bundleList)
		{
			this.languageVersion = languageVersion;
			this.version = version;
			this.loadResourceType = loadResourceType;
			this.bundleDirectory = bundleDirectory;
			_filename = filename;
			_bundlename = filename;
			this.loadState = loadState;
			this.loaded = loaded;
			this.loadCount = loadCount;
			_bundleList = bundleList;
		}
	}

	public class VersionData
	{
		public string LanguageVersion { get; private set; }

		public string Version { get; private set; }

		public string LoadResourceType { get; private set; }

		public string BundleDirectory { get; private set; }

		public string Filename { get; private set; }

		public string BundleList { get; private set; }

		public string BundleName { get; private set; }

		public bool PreDownloaded { get; private set; }

		public long FileSize { get; private set; }

		public VersionData(string languageVersion, string version, string loadResourceType, string bundleDirectory, string filename, bool bPreDownloaded, long fileSize, string bundleList)
		{
			LanguageVersion = languageVersion;
			Version = version;
			LoadResourceType = loadResourceType;
			BundleDirectory = bundleDirectory;
			Filename = filename;
			PreDownloaded = bPreDownloaded;
			FileSize = fileSize;
			BundleList = bundleList;
			BundleName = filename;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadFromWWWAsync_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int tryCount;

		public int maxTryCount;

		public string url;

		public DownloadManager _003C_003E4__this;

		public Action<WWW> callback;

		private WWW _003Cwww_003E5__2;

		private bool _003CbTimeout_003E5__3;

		private float _003CwaitingTime_003E5__4;

		private float _003Cprogress_003E5__5;

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
		public _003CDownloadFromWWWAsync_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			DownloadManager downloadManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003CwaitingTime_003E5__4 += Time.deltaTime;
				if (_003Cwww_003E5__2 != null && _003Cwww_003E5__2.progress > _003Cprogress_003E5__5)
				{
					_003Cprogress_003E5__5 = _003Cwww_003E5__2.progress;
					_003CwaitingTime_003E5__4 = 0f;
				}
				if (_003CwaitingTime_003E5__4 > 15f)
				{
					_003CbTimeout_003E5__3 = true;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_003Cwww_003E5__2 = new WWW(url);
				_003CbTimeout_003E5__3 = false;
				_003CwaitingTime_003E5__4 = 0f;
				_003Cprogress_003E5__5 = 0f;
			}
			if (_003Cwww_003E5__2 != null && !_003Cwww_003E5__2.isDone && !_003CbTimeout_003E5__3)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (_003CbTimeout_003E5__3 || !string.IsNullOrEmpty(_003Cwww_003E5__2.error))
			{
				if (_003Cwww_003E5__2 != null)
				{
					_003Cwww_003E5__2.Dispose();
					_003Cwww_003E5__2 = null;
				}
				if (tryCount < maxTryCount)
				{
					tryCount++;
					downloadManager.StartCoroutine(downloadManager.DownloadFromWWWAsync(tryCount, url, maxTryCount, callback));
				}
				else if (callback != null)
				{
					callback(null);
				}
			}
			else
			{
				if (callback != null)
				{
					callback(_003Cwww_003E5__2);
				}
				if (_003Cwww_003E5__2 != null)
				{
					_003Cwww_003E5__2.Dispose();
					_003Cwww_003E5__2 = null;
				}
			}
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
	private sealed class _003CDownloadAssetAsync_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int tryCount;

		public int maxTryCount;

		public string loadResourceType;

		public string bundleName;

		public DownloadManager _003C_003E4__this;

		public Action<string, string, WWW> callback;

		private WWW _003Cwww_003E5__2;

		private bool _003CbTimeout_003E5__3;

		private float _003CwaitingTime_003E5__4;

		private float _003Cprogress_003E5__5;

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
		public _003CDownloadAssetAsync_003Ed__33(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			DownloadManager downloadManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003CwaitingTime_003E5__4 += Time.deltaTime;
				if (_003Cwww_003E5__2 != null && _003Cwww_003E5__2.progress > _003Cprogress_003E5__5)
				{
					_003Cprogress_003E5__5 = _003Cwww_003E5__2.progress;
					_003CwaitingTime_003E5__4 = 0f;
				}
				if (_003CwaitingTime_003E5__4 > 15f)
				{
					_003CbTimeout_003E5__3 = true;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				string bundleDownloadRootUrl = Common.GetBundleDownloadRootUrl();
				string url = bundleDownloadRootUrl + loadResourceType + "/" + bundleName;
				_003Cwww_003E5__2 = new WWW(url);
				_003CbTimeout_003E5__3 = false;
				_003CwaitingTime_003E5__4 = 0f;
				_003Cprogress_003E5__5 = 0f;
			}
			if (_003Cwww_003E5__2 != null && !_003Cwww_003E5__2.isDone && !_003CbTimeout_003E5__3)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (_003CbTimeout_003E5__3 || !string.IsNullOrEmpty(_003Cwww_003E5__2.error))
			{
				if (_003Cwww_003E5__2 != null)
				{
					_003Cwww_003E5__2.Dispose();
					_003Cwww_003E5__2 = null;
				}
				if (tryCount < maxTryCount)
				{
					tryCount++;
					downloadManager.StartCoroutine(downloadManager.DownloadAssetAsync(loadResourceType, bundleName, tryCount, maxTryCount, callback));
				}
				else if (callback != null)
				{
					callback(loadResourceType, bundleName, null);
				}
			}
			else
			{
				downloadManager.DownloadComplete(loadResourceType, bundleName);
				if (callback != null)
				{
					callback(loadResourceType, bundleName, _003Cwww_003E5__2);
				}
				if (_003Cwww_003E5__2 != null)
				{
					_003Cwww_003E5__2.Dispose();
					_003Cwww_003E5__2 = null;
				}
			}
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

	public const string HEAD = "file://";

	public const string RES_EXTENSION = ".assetbundle";

	public const string RESULT_RECORD = "downloadRecord";

	public const string RESULT_RECORD_EXTENSION = ".txt";

	public const string END_SIGNAL = "end";

	public TextAsset localVersionTextAsset;

	public Dictionary<string, DownLoadRecord> downLoadResult;

	public Dictionary<string, VersionData> localVersionList;

	public Dictionary<string, VersionData> remoteVersionList;

	public string localGameConfigVersion;

	public string remoteGameConfigVersion;

	private static char[] versionSeparator;

	private bool bInitialized;

	private Dictionary<string, List<string>> _mLoadResourceTypeDic;

	public Dictionary<string, List<string>> LoadResouceTypeDic => _mLoadResourceTypeDic;

	private void Start()
	{
		bInitialized = true;
	}

	public void LoadVersionDataFromWWW(WWW versionWWW, ref Dictionary<string, VersionData> list, bool isLocal)
	{
		if (versionWWW != null && string.IsNullOrEmpty(versionWWW.error))
		{
			AssetBundle assetBundle = versionWWW.assetBundle;
			TextAsset textAsset = (assetBundle != null) ? (assetBundle.mainAsset as TextAsset) : null;
			if (textAsset != null)
			{
				LoadVersionDataFromWWW(textAsset, ref list, isLocal);
			}
		}
	}

	public void LoadVersionDataFromWWW(TextAsset ta, ref Dictionary<string, VersionData> list, bool isLocal)
	{
		if (ta == null || string.IsNullOrEmpty(ta.text))
		{
			return;
		}
		if (list == null)
		{
			list = new Dictionary<string, VersionData>();
		}
		string[] array = ta.text.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (!string.IsNullOrEmpty(text))
			{
				string[] array2 = text.Split('\t');
				if (array2.Length >= 8)
				{
					string languageVersion = array2[0];
					string version = array2[1];
					string loadResourceType = array2[2];
					string bundleDirectory = array2[3];
					string filename = array2[4];
					bool bPreDownloaded = false;
					bool.TryParse(array2[5], out bPreDownloaded);
					long fileSize = 0L;
					long.TryParse(array2[6], out fileSize);
					string bundleList = array2[7];
					VersionData versionData = new VersionData(languageVersion, version, loadResourceType, bundleDirectory, filename, bPreDownloaded, fileSize, bundleList);
					string remoteVersionKey = GetRemoteVersionKey(loadResourceType, filename);
					list[remoteVersionKey] = versionData;
					RecordLoadResourceTypeToBundleList(loadResourceType, bundleList);
				}
			}
		}
	}

	public void WriteRecordFile()
	{
		if (downLoadResult == null || downLoadResult.Count == 0)
		{
			return;
		}
		string path = Application.persistentDataPath + "/downloadRecord.txt";
		try
		{
			using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(path, false))
			{
				foreach (KeyValuePair<string, DownLoadRecord> item in downLoadResult)
				{
					if (item.Value != null)
					{
						streamWriter.WriteLine(item.Value.ToString());
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("WriteRecordFile Error: " + ex.Message);
		}
	}

	private void RecordLoadResourceTypeToBundleList(string loadResourceType, string bundleList)
	{
		if (_mLoadResourceTypeDic == null)
		{
			_mLoadResourceTypeDic = new Dictionary<string, List<string>>();
		}
		if (!string.IsNullOrEmpty(loadResourceType) && !string.IsNullOrEmpty(bundleList))
		{
			List<string> list;
			if (!_mLoadResourceTypeDic.TryGetValue(loadResourceType, out list))
			{
				list = new List<string>();
				_mLoadResourceTypeDic[loadResourceType] = list;
			}
			if (!list.Contains(bundleList))
			{
				list.Add(bundleList);
			}
		}
	}

	public static string GetDownloadRecordKey(string loadResourceType, string bundleName)
	{
		return loadResourceType + "_" + bundleName;
	}

	public static string GetRemoteVersionKey(string loadResourceType, string bundleName)
	{
		return loadResourceType + "_" + bundleName;
	}

	private VersionData GetLocalVersionInfo(string loadResourceType, string bundleName)
	{
		string remoteVersionKey = GetRemoteVersionKey(loadResourceType, bundleName);
		VersionData value = null;
		if (localVersionList != null)
		{
			localVersionList.TryGetValue(remoteVersionKey, out value);
		}
		return value;
	}

	private VersionData GetRemoteVersionInfo(string loadResourceType, string bundleName)
	{
		string remoteVersionKey = GetRemoteVersionKey(loadResourceType, bundleName);
		VersionData value = null;
		if (remoteVersionList != null)
		{
			remoteVersionList.TryGetValue(remoteVersionKey, out value);
		}
		return value;
	}

	public List<string> GetAllBundlenameList(string loadResourceType, string realLanguageVersion)
	{
		if (_mLoadResourceTypeDic == null)
		{
			return null;
		}
		List<string> value = null;
		_mLoadResourceTypeDic.TryGetValue(loadResourceType, out value);
		return value;
	}

	public DownLoadRecord.LoadStateEnum NeedDownload(string bundleName, string loadResourceType)
	{
		VersionData remoteVersionInfo = GetRemoteVersionInfo(loadResourceType, bundleName);
		if (remoteVersionInfo == null)
		{
			return DownLoadRecord.LoadStateEnum.Preloaded;
		}
		string downloadRecordKey = GetDownloadRecordKey(loadResourceType, bundleName);
		DownLoadRecord downLoadRecord = null;
		if (downLoadResult != null)
		{
			downLoadResult.TryGetValue(downloadRecordKey, out downLoadRecord);
		}
		if (downLoadRecord == null)
		{
			return DownLoadRecord.LoadStateEnum.NotLoaded;
		}
		if (downLoadRecord.LoadState == DownLoadRecord.LoadStateEnum.Downloaded && downLoadRecord.Version == remoteVersionInfo.Version)
		{
			return DownLoadRecord.LoadStateEnum.Downloaded;
		}
		return DownLoadRecord.LoadStateEnum.NotLoaded;
	}

	public void DownloadComplete(string loadResourceType, string bundleName)
	{
		VersionData remoteVersionInfo = GetRemoteVersionInfo(loadResourceType, bundleName);
		if (remoteVersionInfo != null)
		{
			string downloadRecordKey = GetDownloadRecordKey(loadResourceType, bundleName);
			if (downLoadResult == null)
			{
				downLoadResult = new Dictionary<string, DownLoadRecord>();
			}
			DownLoadRecord downLoadRecord = null;
			if (!downLoadResult.TryGetValue(downloadRecordKey, out downLoadRecord))
			{
				downLoadRecord = new DownLoadRecord(remoteVersionInfo.LanguageVersion, remoteVersionInfo.Version, remoteVersionInfo.LoadResourceType, remoteVersionInfo.BundleDirectory, remoteVersionInfo.Filename, DownLoadRecord.LoadStateEnum.Downloaded, true, 1, remoteVersionInfo.BundleList);
				downLoadResult[downloadRecordKey] = downLoadRecord;
			}
			else
			{
				downLoadRecord.LoadState = DownLoadRecord.LoadStateEnum.Downloaded;
				downLoadRecord.Version = remoteVersionInfo.Version;
				downLoadRecord.loaded = true;
				downLoadRecord.loadCount++;
			}
			WriteRecordFile();
		}
	}

	public string GetHighestVersion()
	{
		return null;
	}

	public void DownloadFromWWW(string url, int maxTryCount, Action<WWW> callback)
	{
		StartCoroutine(DownloadFromWWWAsync(1, url, maxTryCount, callback));
	}

	[IteratorStateMachine(typeof(_003CDownloadFromWWWAsync_003Ed__31))]
	private IEnumerator DownloadFromWWWAsync(int tryCount, string url, int maxTryCount, Action<WWW> callback)
	{
		_003CDownloadFromWWWAsync_003Ed__31 _003CDownloadFromWWWAsync_003Ed__ = new _003CDownloadFromWWWAsync_003Ed__31(0);
		_003CDownloadFromWWWAsync_003Ed__._003C_003E4__this = this;
		_003CDownloadFromWWWAsync_003Ed__.tryCount = tryCount;
		_003CDownloadFromWWWAsync_003Ed__.url = url;
		_003CDownloadFromWWWAsync_003Ed__.maxTryCount = maxTryCount;
		_003CDownloadFromWWWAsync_003Ed__.callback = callback;
		return _003CDownloadFromWWWAsync_003Ed__;
	}

	public void DownloadAsset(string loadResourceType, string bundleName, int maxTryCount, Action<string, string, WWW> callback)
	{
		StartCoroutine(DownloadAssetAsync(loadResourceType, bundleName, 1, maxTryCount, callback));
	}

	[IteratorStateMachine(typeof(_003CDownloadAssetAsync_003Ed__33))]
	private IEnumerator DownloadAssetAsync(string loadResourceType, string bundleName, int tryCount, int maxTryCount, Action<string, string, WWW> callback)
	{
		_003CDownloadAssetAsync_003Ed__33 _003CDownloadAssetAsync_003Ed__ = new _003CDownloadAssetAsync_003Ed__33(0);
		_003CDownloadAssetAsync_003Ed__._003C_003E4__this = this;
		_003CDownloadAssetAsync_003Ed__.loadResourceType = loadResourceType;
		_003CDownloadAssetAsync_003Ed__.bundleName = bundleName;
		_003CDownloadAssetAsync_003Ed__.tryCount = tryCount;
		_003CDownloadAssetAsync_003Ed__.maxTryCount = maxTryCount;
		_003CDownloadAssetAsync_003Ed__.callback = callback;
		return _003CDownloadAssetAsync_003Ed__;
	}
}
