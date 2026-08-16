using System.Collections.Generic;

public class ItemAtlasManager
{
	public enum ItemAtlasType
	{
		item = 0,
		card = 1,
		_NUM = 2
	}

	public string[] atlasNames;

	public string[][] itemHeadNames;

	private List<UIAtlas> atlasGroup;

	private void InitAtlas()
	{
	}

	public void Load()
	{
	}

	public void Clear()
	{
	}

	public UIAtlas Get(string spriteName, out bool notFound)
	{
		notFound = default(bool);
		return null;
	}

	public UIAtlas Get(ItemAtlasType type)
	{
		return null;
	}
}
