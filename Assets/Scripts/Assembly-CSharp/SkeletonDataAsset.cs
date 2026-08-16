using Spine;
using UnityEngine;

public class SkeletonDataAsset : ScriptableObject
{
	public TextAsset idleAnimation;

	public TextAsset uiAnimation;

	public TextAsset battleAnimation;

	public AtlasAsset atlasAsset;

	public JsonAsset customJsonAsset;

	public CharactersType characterType;

	public float scale;

	public string[] fromAnimation;

	public string[] toAnimation;

	public float[] duration;

	private SkeletonData skeletonData;

	private AnimationStateData stateData;

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	public SkeletonData GetSkeletonData(bool quiet, string[] animationName = null)
	{
		return null;
	}

	public AnimationStateData GetAnimationStateData(string[] animations)
	{
		return null;
	}
}
