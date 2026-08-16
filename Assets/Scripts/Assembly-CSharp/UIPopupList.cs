using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2
	}

	public enum OpenOn
	{
		ClickOrTap = 0,
		RightClick = 1,
		DoubleClick = 2,
		Manual = 3
	}

	public delegate void LegacyEvent(string val);

	[CompilerGenerated]
	private sealed class _003CUpdateTweenPosition_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private TweenPosition _003Ctp_003E5__2;

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
		public _003CUpdateTweenPosition_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CCloseIfUnselected_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

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
		public _003CCloseIfUnselected_003Ed__91(int _003C_003E1__state)
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

	public static UIPopupList current;

	private const float animSpeed = 0.15f;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Position position;

	public NGUIText.Alignment alignment;

	public List<string> items;

	public List<object> itemData;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public OpenOn openOn;

	public List<EventDelegate> onChange;

	[SerializeField]
	[HideInInspector]
	private string mSelectedItem;

	[SerializeField]
	[HideInInspector]
	private UIPanel mPanel;

	[SerializeField]
	[HideInInspector]
	private GameObject mChild;

	[SerializeField]
	[HideInInspector]
	private UISprite mBackground;

	[SerializeField]
	[HideInInspector]
	private UISprite mHighlight;

	[SerializeField]
	[HideInInspector]
	private UILabel mHighlightedLabel;

	[HideInInspector]
	[SerializeField]
	private List<UILabel> mLabelList;

	[SerializeField]
	[HideInInspector]
	private float mBgBorder;

	[NonSerialized]
	private GameObject mSelection;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName;

	[SerializeField]
	[HideInInspector]
	private float textScale;

	[HideInInspector]
	[SerializeField]
	private UIFont font;

	[HideInInspector]
	[SerializeField]
	private UILabel textLabel;

	private LegacyEvent mLegacyEvent;

	private bool mUseDynamicFont;

	private bool mTweening;

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public LegacyEvent onSelectionChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isOpen => false;

	public string value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object data => null;

	[Obsolete("Use 'value' instead")]
	public string selection
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool handleEvents
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool isValid => false;

	private int activeFontSize => 0;

	private float activeFontScale => 0f;

	public void Clear()
	{
	}

	public void AddItem(string text)
	{
	}

	public void AddItem(string text, object data)
	{
	}

	protected void TriggerCallbacks()
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	private void OnLocalize()
	{
	}

	private void Highlight(UILabel lbl, bool instant)
	{
	}

	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateTweenPosition_003Ed__76))]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	private void Select(UILabel lbl, bool instant)
	{
	}

	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	private void OnItemClick(GameObject go)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void OnDisable()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	public void Close()
	{
	}

	private void AnimateColor(UIWidget widget)
	{
	}

	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseIfUnselected_003Ed__91))]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	public void Show()
	{
	}

	public void FreshList()
	{
	}
}
