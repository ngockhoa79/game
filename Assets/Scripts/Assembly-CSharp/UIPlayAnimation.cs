using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Animation")]
[ExecuteInEditMode]
public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current;

	public Animation target;

	public Animator animator;

	public string clipName;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool clearSelection;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public List<EventDelegate> onFinished;

	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	private bool mStarted;

	private bool mActivated;

	private bool dragHighlight;

	private bool dualState => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnToggle()
	{
	}

	private void OnDragOver()
	{
	}

	private void OnDragOut()
	{
	}

	private void OnDrop(GameObject go)
	{
	}

	public void Play(bool forward)
	{
	}

	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	private void OnFinished()
	{
	}
}
