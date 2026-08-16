using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/Core/tk2dUICamera")]
public class tk2dUICamera : MonoBehaviour
{
	public enum tk2dRaycastType
	{
		Physics3D = 0,
		Physics2D = 1
	}

	[SerializeField]
	private LayerMask raycastLayerMask;

	[SerializeField]
	private tk2dRaycastType raycastType;

	public tk2dRaycastType RaycastType => default(tk2dRaycastType);

	public LayerMask FilteredMask => default(LayerMask);

	public Camera HostCamera => null;

	public void AssignRaycastLayerMask(LayerMask mask)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
