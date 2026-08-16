using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IceUIReusableList<Data> where Data : class
{
	public interface IVisualizer
	{
		GameObject CreateWidget(Transform widgetsHolder);

		GameObject CreateSeparator(Transform widgetsHolder);

		void SetData(GameObject widget, Data data);

		void ClearData(GameObject widget);
	}

	private class Item
	{
		public readonly IceUIReusableList<Data> Owner;

		private float width;

		private float height;

		private string name;

		public GameObject Widget { get; private set; }

		public GameObject Separator { get; private set; }

		public bool IsVisible { get; private set; }

		public int DataIndex { get; private set; }

		public float Width => 0f;

		public float Height => 0f;

		public Item(IceUIReusableList<Data> owner)
		{
		}

		public void SetData(int dataIndex)
		{
		}

		internal bool CheckVisibility(Bounds clipperBounds)
		{
			return false;
		}

		public void UpdateDimensions()
		{
		}

		public void Rename(int index)
		{
		}

		public void Recreate()
		{
		}
	}

	public class EncapsuleData
	{
		public Data Data;

		public GameObject Widget;
	}

	[CompilerGenerated]
	private sealed class _003Cget_Datas_003Ed__48 : IEnumerable<Data>, IEnumerable, IEnumerator<Data>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Data _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public IceUIReusableList<Data> _003C_003E4__this;

		private List<Data>.Enumerator _003C_003E7__wrap1;

		Data IEnumerator<Data>.Current
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
		public _003Cget_Datas_003Ed__48(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<Data> IEnumerable<Data>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ItemWidgets_003Ed__53 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private GameObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public IceUIReusableList<Data> _003C_003E4__this;

		private List<Item>.Enumerator _003C_003E7__wrap1;

		GameObject IEnumerator<GameObject>.Current
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
		public _003Cget_ItemWidgets_003Ed__53(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<GameObject> IEnumerable<GameObject>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_VisibleItemWidgets_003Ed__55 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private GameObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public IceUIReusableList<Data> _003C_003E4__this;

		private List<Item>.Enumerator _003C_003E7__wrap1;

		GameObject IEnumerator<GameObject>.Current
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
		public _003Cget_VisibleItemWidgets_003Ed__55(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<GameObject> IEnumerable<GameObject>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public readonly IVisualizer Visualizer;

	public readonly Transform WidgetsHolder;

	public readonly UIPanel Clipper;

	public readonly bool IsVertical;

	private readonly List<Data> datas;

	private readonly List<Item> items;

	private int firstCreatedDataIndex;

	private readonly UIWidget header;

	private readonly UIWidget tailer;

	private bool isHeaderVisible;

	private bool isTailerVisible;

	private bool forceUpdate;

	private Vector3 initClipperPos;

	private Vector4 baseClipperRegion;

	private Vector2 clipOffSet;

	private int _cleanCounter;

	public int DataCount => 0;

	public List<Data> Data1 => null;

	public IEnumerable<Data> Datas
	{
		[IteratorStateMachine(typeof(IceUIReusableList<>._003Cget_Datas_003Ed__48))]
		get
		{
			return null;
		}
	}

	public IEnumerable<GameObject> ItemWidgets
	{
		[IteratorStateMachine(typeof(IceUIReusableList<>._003Cget_ItemWidgets_003Ed__53))]
		get
		{
			return null;
		}
	}

	public IEnumerable<GameObject> VisibleItemWidgets
	{
		[IteratorStateMachine(typeof(IceUIReusableList<>._003Cget_VisibleItemWidgets_003Ed__55))]
		get
		{
			return null;
		}
	}

	public event Action<Data> OnAdd
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

	public event Action<Data, GameObject> OnShow
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

	public event Action<Data, GameObject> OnHide
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

	public static bool IsVisible(Transform widget, Transform clipper, Bounds clipperBounds)
	{
		return false;
	}

	public IceUIReusableList(IVisualizer visualizer, Transform widgetsHolder, UIPanel clipper, bool isVertical)
	{
	}

	public void CleanMemory()
	{
	}

	public IceUIReusableList(IVisualizer visualizer, Transform widgetsHolder, UIPanel clipper)
	{
	}

	private UIWidget createPlaceHolder()
	{
		return null;
	}

	public Bounds GetClipperBounds()
	{
		return default(Bounds);
	}

	private bool updateVisibility()
	{
		return false;
	}

	private bool reorg()
	{
		return false;
	}

	private bool layout()
	{
		return false;
	}

	public void CheckWidgetsVisibility()
	{
	}

	public void Invalidate()
	{
	}

	public void Add(Data data)
	{
	}

	public void Set(int index, Data data)
	{
	}

	public void Clear()
	{
	}

	public int IndexOf(Data data)
	{
		return 0;
	}

	public Data GetData(int index)
	{
		return null;
	}

	public GameObject GetWidget(Data data)
	{
		return null;
	}

	public T GetWidget<T>(Data data) where T : Component
	{
		return null;
	}

	public void RefreshData(Data data)
	{
	}

	public void RefreshData()
	{
	}

	public void RecreateWidgets()
	{
	}

	public List<EncapsuleData> GetWidgetData()
	{
		return null;
	}
}
