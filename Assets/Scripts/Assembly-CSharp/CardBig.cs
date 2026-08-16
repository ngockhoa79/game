using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class CardBig : MonoBehaviour
{
	public UITexture txHeader;

	public UILabel lbName;

	[SerializeField]
	private UISprite[] spStars;

	public CardFrame Frame;

	public HeroProfession Profession;

	public IceAnimatorTotalCommander Animation;

	public BoxCollider Box;

	private HeroConfig mHc;

	private bool mPlayAnimation;

	public Action<CardBig> E_OnTextureLoad;

	private void Start()
	{
	}

	public void Clear()
	{
	}

	public void SetColliderEnable(bool enable)
	{
	}

	public HeroConfig GetData()
	{
		return null;
	}

	public bool IsTextureLoad()
	{
		return false;
	}

	public void SetData(HeroConfig hcfg, bool playAnimation = true)
	{
	}

	public void LoadAsyncCardTexture()
	{
	}

	private void OnCardTextureLoad(object o)
	{
	}

	public void SetCardStars(int num)
	{
	}
}
