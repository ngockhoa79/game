using UnityEngine;

[AddComponentMenu("2D Toolkit/Backend/tk2dSpriteAnimation")]
public class tk2dSpriteAnimation : MonoBehaviour
{
	public tk2dSpriteAnimationClip[] clips;

	public tk2dSpriteAnimationClip FirstValidClip => null;

	public tk2dSpriteAnimationClip GetClipByName(string name)
	{
		return null;
	}

	public tk2dSpriteAnimationClip GetClipById(int id)
	{
		return null;
	}

	public int GetClipIdByName(string name)
	{
		return 0;
	}

	public int GetClipIdByName(tk2dSpriteAnimationClip clip)
	{
		return 0;
	}
}
