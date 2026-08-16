using System;
using Ice.ProjectCos.UI.DataModel;

public class ItemShopGoods_N : IceUIBase
{
	public ItemShopGoods[] ShopItemRow;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetRowItem(int index, ShopItem data, ShopType shopType)
	{
	}
}
