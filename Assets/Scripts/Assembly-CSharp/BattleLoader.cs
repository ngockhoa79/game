using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Foundation;
using UnityEngine;

public class BattleLoader : MonoBehaviour
{
	public delegate void DelegateInitialized(bool successfully);

	public delegate void DelegateStartLoadingResources();

	public delegate void DelegateFinishLoadingResources();

	public enum EditorModeEnum
	{
		ReleaseMode = 0,
		BattleReportMode = 1,
		CosEditorMode = 2
	}

	private enum BattleLoadState
	{
		None = 0,
		GlobalsInitialized = 1,
		LoadingBattleGlobalVariable = 2,
		LoadingBattleReport = 3,
		LoadingResources = 4,
		WaitingFinishLoadingResource = 5,
		LoadingBattleUI = 6,
		LoadingBattleElements = 7,
		SendPlayBattleReportMsg = 8,
		LoadCompleted = 9,
		Destroy = 10,
		Finish = 11
	}

	private class ToLoadResourcesPackage
	{
		public class ToLoadResourcesList
		{
			private string _loadResourceType;

			private string _realBundleName;

			private List<ToLoadResourcesContent> _list;

			public string LoadResourceType => null;

			public string RealBundleName => null;

			public List<ToLoadResourcesContent> List => null;

			public ToLoadResourcesList(string loadResourceType, string bundleName)
			{
			}
		}

		public class ToLoadResourcesContent
		{
			private BattleResourceItem _content;

			private bool _bLoadComplete;

			public BattleResourceItem Content => null;

			public bool bLoadComplete => false;

			public ToLoadResourcesContent(BattleResourceItem data)
			{
			}

			public void LoadComplete()
			{
			}
		}

		private Dictionary<string, ToLoadResourcesList> _dic;

		public Dictionary<string, ToLoadResourcesList> Dic => null;

		public void SetData(List<BattleResourceItem> toLoadResources)
		{
		}

		public void Clear()
		{
		}

		public bool IsAllComplete()
		{
			return false;
		}

		public List<Foundation.Tuple<string, string>> GetRealBundleNames()
		{
			return null;
		}

		public static string GetKey(string loadResourceType, string bundleName)
		{
			return null;
		}
	}

	public GameObject initializedShader;

	public DelegateInitialized E_OnInitialized;

	private Action pushToPoolManagerCallback;

	private ToLoadResourcesPackage _toLoadPackage;

	private bool bTempVar;

	private int bTempInt;

	private List<BattleResourceItem> toLoad;

	private GameObject parent;

	public EditorModeEnum EditorMode;

	private bool hasEnterTestMode;

	private bool hasEnterLoadComplete;

	private BattleLoadState _state;

	public event DelegateStartLoadingResources E_OnStartLaodResources
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

	public event DelegateFinishLoadingResources E_OnFinishLoadResources
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void TestMode()
	{
	}

	private void Update()
	{
	}

	public void FinishLoadResources()
	{
	}

	public void EndLoadBattleUI()
	{
	}

	public void EndLoadBattleElements()
	{
	}

	private void EnterState(BattleLoadState state)
	{
	}

	public void PushToPoolManager(List<BattleResourceItem> toLoadResources, Action callback = null)
	{
	}

	private void SpawnToPoolManager(string loadResourceType, string realBundleName)
	{
	}

	private void LoadAndPushToPoolManagerAsync(string loadResourceType, string realBundleName)
	{
	}
}
