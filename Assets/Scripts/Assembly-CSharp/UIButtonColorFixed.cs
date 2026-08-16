using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Button Color fixed")]
public class UIButtonColorFixed : UIWidgetContainer
{
	protected enum State
	{
		Normal = 0,
		Hover = 1,
		Pressed = 2,
		Disabled = 3
	}

	public GameObject tweenTarget;

	public float initAlpha;

	public Color hover;

	public Color pressed;

	public Color disabledColor;

	public float duration;

	protected Color mColor;

	protected bool mInitDone;

	protected UIWidget mWidget;

	protected State mState;

	public Color defaultColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public virtual bool isEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnHover(bool isOver)
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void OnDragOver()
	{
	}

	protected virtual void OnDragOut()
	{
	}

	protected virtual void OnSelect(bool isSelected)
	{
	}

	protected virtual void SetState(State state, bool instant)
	{
	}
}
