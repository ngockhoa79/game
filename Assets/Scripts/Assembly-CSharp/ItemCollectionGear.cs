using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemCollectionGear : MonoBehaviour
{
	public GameObject Root;

	public UISprite spFrame;

	public UISprite spBg;

	public UITexture txIcon;

	public UILabel lbName;

	public UIEventListener ev;

	public int BaseWidgetDepth;

	public Action<Gear, ItemCollectionGear> OnGearDetail;

	private Gear mData;

	[HideInInspector]
	public UIDragScrollView Dragger;

	private void Start()
	{
	}

	public void UpdateWidgetDepth()
	{
	}

	public void SetEmpty()
	{
	}

	public void SetData(Gear g, bool loadTexture = false)
	{
	}

	public void LoadTexture()
	{
	}

	public void ClearTexture()
	{
	}

	private void OnClick(GameObject go)
	{
	}

	private void OnPress(GameObject go, bool pressed)
	{
	}

	private void OnDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnScroll(GameObject go, float delta)
	{
	}
}
