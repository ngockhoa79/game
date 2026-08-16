using System;
using UnityEngine;

public class SmeltJourneyBackgroundMotion : MonoBehaviour
{
	public enum Movement
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Serializable]
	public class BackgroundStruct
	{
		public Transform background;

		public float MovementFactor;
	}

	public Transform RefBackground;

	public BackgroundStruct[] Backgrounds;

	public Movement MovementDirection;

	private Vector3 StartPos;

	public UIDragObject DragObject;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
