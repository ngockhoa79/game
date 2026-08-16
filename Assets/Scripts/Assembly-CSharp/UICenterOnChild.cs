using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
public class UICenterOnChild : MonoBehaviour
{
	public delegate void OnCenterCallback(GameObject centeredObject);

	public Action<bool, int, GameObject> OnSelectionChange;

	private int mSelectionIndex;

	public float springStrength;

	public float nextPageThreshold;

	public SpringPanel.OnFinished onFinished;

	public OnCenterCallback onCenter;

	private UIScrollView mScrollView;

	private GameObject mCenteredObject;

	public GameObject centeredObject => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDragFinished()
	{
	}

	private void OnValidate()
	{
	}

	[ContextMenu("Execute")]
	public void Recenter()
	{
	}

	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	public void CenterOn(Transform target)
	{
	}
}
