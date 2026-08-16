using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class BattleCameraZoom : FsmStateAction
{
	[RequiredField]
	public CameraZoomType zoomType;

	[RequiredField]
	public FsmFloat zoomTime;

	public FsmGameObject target;

	public FsmFloat targetPercent;

	private Camera go;

	private float moveSpeed;

	private float scaleSpeed;

	private float targetSize;

	private Vector2 targetPlanePos;

	public override void OnEnter()
	{
	}

	private void CalSpeed()
	{
	}

	public override void OnUpdate()
	{
	}
}
