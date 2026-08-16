using UnityEngine;

[AddComponentMenu("2D Toolkit/Demo/tk2dDemoRuntimeSpriteController")]
public class tk2dDemoRuntimeSpriteController : MonoBehaviour
{
	public Texture2D runtimeTexture;

	public Texture2D texturePackerTexture;

	public TextAsset texturePackerExportFile;

	public GameObject destroyOnStart;

	private tk2dBaseSprite spriteInstance;

	private tk2dSpriteCollectionData spriteCollectionInstance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void DestroyData()
	{
	}

	private void DoDemoTexturePacker(tk2dSpriteCollectionSize spriteCollectionSize)
	{
	}

	private void DoDemoRuntimeSpriteCollection(tk2dSpriteCollectionSize spriteCollectionSize)
	{
	}

	private void OnGUI()
	{
	}
}
