using UnityEngine;

public class tk2dTileMapDemoFollowCam : MonoBehaviour
{
	private tk2dCamera cam;

	public Transform target;

	public float followSpeed;

	public float minZoomSpeed;

	public float maxZoomSpeed;

	public float maxZoomFactor;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
