using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class ItemCollectionPageHero : ItemCollectionPage
{
	private List<ItemCollectionHero> mItems;

	protected List<HeroConfig> mData;

	public UIItemPool<ItemCollectionHero> UIPool { get; set; }

	public void SetData(List<HeroConfig> list)
	{
	}

	public override void FillPageUI()
	{
	}

	public override void RefreshPage()
	{
	}

	public override void LoadAllTexture()
	{
	}

	public override void UnLoadAllTexture()
	{
	}

	public override void Clear()
	{
	}
}
