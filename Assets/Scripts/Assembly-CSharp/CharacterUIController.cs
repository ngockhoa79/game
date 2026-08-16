using UnityEngine;

public class CharacterUIController : MonoBehaviour
{
	public ObjectScroller scroller;

	public float touchDistance;

	public float speedDownRatio;

	public float maxSpeed;

	public float minSpeed;

	public float height;

	public string defaultState;

	private bool _enable;

	private float _scrollSpeed;

	private float ratio;

	private bool bAnimating;

	[HideInInspector]
	public bool bEnbale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void Update()
	{
	}

	private void SetScrollSpeed(float speed)
	{
	}

	private void LateUpdate()
	{
	}

	private void Reset()
	{
	}
}
