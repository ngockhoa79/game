using System.Collections.Generic;
using UnityEngine;

public class tk2dUIDemo6Controller : tk2dUIBaseDemoController
{
	private class ItemDef
	{
		public string name;

		public int score;

		public int time;

		public Color color;
	}

	public tk2dUILayout prefabItem;

	private float itemStride;

	public tk2dUIScrollableArea scrollableArea;

	public tk2dTextMesh numItemsTextMesh;

	private List<ItemDef> allItems;

	private List<Transform> cachedContentItems;

	private List<Transform> unusedContentItems;

	private int firstCachedItem;

	private int maxVisibleItems;

	private int numToAdd;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void CustomizeListObject(Transform contentRoot, int itemId)
	{
	}

	private void SetItemCount(int numItems)
	{
	}

	private void OnScroll(tk2dUIScrollableArea scrollableArea)
	{
	}

	private void UpdateListGraphics()
	{
	}

	private void AddMoreItems()
	{
	}

	private void ResetItems()
	{
	}
}
