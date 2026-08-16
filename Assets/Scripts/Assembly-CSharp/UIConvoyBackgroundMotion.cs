using UnityEngine;

public class UIConvoyBackgroundMotion : MonoBehaviour
{
	public Transform BackgroundTr;

	public UIEventListener DragListener;

	public Transform SeaImageTr;

	public Transform LandImageTr;

	public Transform CloudImageTr;

	public Transform SkyImageTr;

	public Transform LandTr;

	public Transform CloudTr;

	public Transform SkyTr;

	private float MotionFactor_Land;

	private float MotionFactor_Cloud;

	private float MotionFactor_Sky;

	private bool isStart;

	private Vector3 StartPos;

	private Vector3 LandPos;

	private Vector3 CloudPos;

	private Vector3 SkyPos;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDragListener(GameObject obj, Vector2 v2)
	{
	}
}
