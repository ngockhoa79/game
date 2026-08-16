using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemCollectionSkill : MonoBehaviour
{
	public GameObject Root;

	public UISprite spFrame;

	public UISprite spBg;

	public UISprite spTypeSpec;

	public UITexture txIcon;

	public UILabel lbName;

	public UIEventListener ev;

	public UIStarsRow Stars;

	public int BaseWidgetDepth;

	private const string SkillTypeSpec = "SkillTypeSpec";

	private const string GearTypeIcon = "GearTypeIcon";

	public Action<Skill, ItemCollectionSkill> OnSkillDetail;

	private Skill mData;

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

	public void SetData(Skill sk, bool loadTexture = false)
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
