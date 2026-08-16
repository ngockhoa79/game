using UnityEngine;

public class CharacterScrollerController : MonoBehaviour
{
	public Camera mainCamera;

	public ObjectScroller scroller;

	public float touchDistance;

	public float speedDownRatio;

	public float maxSpeed;

	public float minSpeed;

	public float height;

	private bool _enable;

	private bool bDragging;

	private bool bReadyEndDragging;

	private Vector2 startDragPosition;

	private Vector2 lastDragPosition;

	private float _scrollSpeed;

	private float ratio;

	private Vector2 minCoor;

	private Vector2 maxCoor;

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

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public bool TryGetInput(out Vector2 coordinate, Vector2 minCoordinate, Vector2 maxCoordinate)
	{
		coordinate = default(Vector2);
		return false;
	}

	private void Reset()
	{
	}
}
