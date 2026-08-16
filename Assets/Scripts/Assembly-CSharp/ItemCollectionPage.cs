using UnityEngine;

public abstract class ItemCollectionPage : MonoBehaviour
{
	public UIGrid gdItems;

	public UIDragScrollView Dragger;

	public abstract void FillPageUI();

	public abstract void RefreshPage();

	public abstract void LoadAllTexture();

	public abstract void UnLoadAllTexture();

	public abstract void Clear();
}
