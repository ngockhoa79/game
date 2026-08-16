using System;

[Serializable]
public class tk2dSpriteAnimationFrame
{
	public tk2dSpriteCollectionData spriteCollection;

	public int spriteId;

	public bool triggerEvent;

	public string eventInfo;

	public int eventInt;

	public float eventFloat;

	public void CopyFrom(tk2dSpriteAnimationFrame source)
	{
	}

	public void CopyTriggerFrom(tk2dSpriteAnimationFrame source)
	{
	}

	public void ClearTrigger()
	{
	}

	public void CopyFrom(tk2dSpriteAnimationFrame source, bool full)
	{
	}
}
