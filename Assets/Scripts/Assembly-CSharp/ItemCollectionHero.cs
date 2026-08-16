using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemCollectionHero : MonoBehaviour
{
	public GameObject Root;

	public UISprite spBg;

	public UIEventListener ev;

	public UISprite spFrame;

	public UITexture txIcon;

	public UILabel lbName;

	public UIStarsRow CardStars;

	public JobIcon CardJobIcon;

	public int BaseWidgetDepth;

	private HeroConfig mData;

	public Action<HeroConfig, ItemCollectionHero> OnClickDetail;

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

	public virtual void SetData(HeroConfig hc, bool loadTexture = false)
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
