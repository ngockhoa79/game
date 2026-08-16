using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/Sprite/tk2dSpriteFromTexture")]
public class tk2dSpriteFromTexture : MonoBehaviour
{
	public Texture texture;

	public tk2dSpriteCollectionSize spriteCollectionSize;

	public tk2dBaseSprite.Anchor anchor;

	private tk2dSpriteCollectionData spriteCollection;

	private tk2dBaseSprite _sprite;

	private tk2dBaseSprite Sprite => null;

	public bool HasSpriteCollection => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Create(tk2dSpriteCollectionSize spriteCollectionSize, Texture texture, tk2dBaseSprite.Anchor anchor)
	{
	}

	public void Clear()
	{
	}

	public void ForceBuild()
	{
	}

	private void DestroyInternal()
	{
	}
}
