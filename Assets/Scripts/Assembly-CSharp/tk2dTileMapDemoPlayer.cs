using UnityEngine;

public class tk2dTileMapDemoPlayer : MonoBehaviour
{
	public tk2dTextMesh textMesh;

	public tk2dTextMesh textMeshLabel;

	private Vector3 textMeshOffset;

	private bool textInitialized;

	public float addForceLimit;

	public float amount;

	public float torque;

	private tk2dSprite sprite;

	private int score;

	private float forceWait;

	private float moveX;

	private bool AllowAddForce => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
