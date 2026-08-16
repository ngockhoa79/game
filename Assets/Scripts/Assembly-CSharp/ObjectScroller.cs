using System.Collections.Generic;
using UnityEngine;

public class ObjectScroller : MonoBehaviour
{
	private struct Content
	{
		public Vector3 position;

		public Vector3 scale;
	}

	public List<GameObject> keyObjList;

	public GameObject[] sideList;

	public float ratio;

	private GameObject[] curObjList;

	private List<Content> initList;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetAnimation(float deltaDistance)
	{
	}
}
