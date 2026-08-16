using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Foundation;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class TestResourcesLoader : MonoBehaviour
{
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

	[CompilerGenerated]
	private sealed class _003Ctest_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestResourcesLoader _003C_003E4__this;

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
		public _003Ctest_003Ed__6(int _003C_003E1__state)
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
	private sealed class _003CPushToPoolManagerAsync_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<BattleResourceItem> toLoadResources;

		public TestResourcesLoader _003C_003E4__this;

		public Action callback;

		private List<Foundation.Tuple<string, string>>.Enumerator _003C_003E7__wrap1;

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
		public _003CPushToPoolManagerAsync_003Ed__9(int _003C_003E1__state)
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
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public bool bLoadFinished;

		internal void _003CLoadAndPushToPoolManagerAsync_003Eb__0(bool bSuccess)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadAndPushToPoolManagerAsync_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string loadResourceType;

		public string realBundleName;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		public TestResourcesLoader _003C_003E4__this;

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
		public _003CLoadAndPushToPoolManagerAsync_003Ed__11(int _003C_003E1__state)
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

	private BattleReportProto battleReportProto;

	private Action pushToPoolManagerCallback;

	private ToLoadResourcesPackage _toLoadPackage;

	private GameObject parent;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003Ctest_003Ed__6))]
	private IEnumerator test()
	{
		return null;
	}

	private void LoadBattleRoundResource(int round)
	{
	}

	public void PushToPoolManager(List<BattleResourceItem> toLoadResources, Action callback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPushToPoolManagerAsync_003Ed__9))]
	public IEnumerator PushToPoolManagerAsync(List<BattleResourceItem> toLoadResources, Action callback = null)
	{
		return null;
	}

	private void SpawnToPoolManager(string loadResourceType, string realBundleName)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAndPushToPoolManagerAsync_003Ed__11))]
	private IEnumerator LoadAndPushToPoolManagerAsync(string loadResourceType, string realBundleName)
	{
		return null;
	}
}
