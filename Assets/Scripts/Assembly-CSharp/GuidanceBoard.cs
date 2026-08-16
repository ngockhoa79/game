using UnityEngine;

public class GuidanceBoard : MonoBehaviour
{
	public enum Mode
	{
		Completed = 0,
		AddFriend = 1
	}

	public IceAnimatorTotalCommander Anim;

	public MeshCollider MC;

	public Vector2 CenterPoint;

	public float ViewPortWidth;

	public float ViewPortHeight;

	private const int ValidWidth = 9600;

	private const int ValidHeight = 6400;

	private float halfValidWidth;

	private float halfValidHeight;

	private float halfViewPortWidth;

	private float halfViewPortHeight;

	public Transform Finger;

	private void create(Mode m)
	{
	}

	private void clamp(bool force)
	{
	}

	private void createMeshCollider()
	{
	}

	public void StandUp(Mode m)
	{
	}
}
