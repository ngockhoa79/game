using Spine;
using UnityEngine;

public class AtlasAsset : ScriptableObject
{
	public TextAsset atlasFile;

	public TextAsset skinFile;

	public Material[] materials;

	private Atlas atlas;

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	public Atlas GetAtlas()
	{
		return null;
	}
}
