using System;
using UnityEngine;

[AddComponentMenu("UI Switch")]
[ExecuteInEditMode]
public class UISwitch : UISlider
{
	public int StateCount;

	public UISprite[] BgSprites;

	public Action<int, int> E_OnChanged;

	public Action<bool, bool> E_SwitchChanged;

	[SerializeField]
	[HideInInspector]
	protected float mSize;

	protected int CurrentState;

	public float transitionDuration;

	protected bool inTransition;

	protected float transitionFactor;

	protected bool invokeEventAfterTransition;

	protected int transitionTargetState;

	public int DefaultIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Switch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int SwitchState
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SwitchStateInvokeEvent
	{
		set
		{
		}
	}

	public float barSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnStart()
	{
	}

	private new void Update()
	{
	}

	protected override float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	public override void ForceUpdate()
	{
	}

	protected void UpdateBgSprites(bool printDebugInfo = false)
	{
	}

	protected void OnPress(GameObject go)
	{
	}

	protected void OnDragThumb(GameObject go, Vector2 delta)
	{
	}

	protected void OnDragThumbEnd(GameObject go)
	{
	}

	public void AnimateSetState(int TargetState, bool invokeEvent)
	{
	}

	public void SetState(int TargetState, bool invokeEvent)
	{
	}

	public void SetStateByValue(float TargetValue, bool invokeEvent)
	{
	}

	protected float StateToValue(int sourceState)
	{
		return 0f;
	}

	protected int ValueToState(float sourceValue)
	{
		return 0;
	}
}
