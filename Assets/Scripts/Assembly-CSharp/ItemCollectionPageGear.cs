using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class ItemCollectionPageGear : ItemCollectionPage
{
	private List<ItemCollectionGear> mItems;

	protected List<Gear> mData;

	public UIItemPool<ItemCollectionGear> UIPool { get; set; }

	public void SetData(List<Gear> list)
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
