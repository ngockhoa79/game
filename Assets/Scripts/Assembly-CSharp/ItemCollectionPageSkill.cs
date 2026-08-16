using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class ItemCollectionPageSkill : ItemCollectionPage
{
	private List<ItemCollectionSkill> mItems;

	protected List<Skill> mData;

	public UIItemPool<ItemCollectionSkill> UIPool { get; set; }

	public void SetData(List<Skill> list)
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
