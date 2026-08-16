using System;
using UnityEngine;

public class UICeCardThumbnail : IceUIBase
{
	public Action OnThumbnailClicked;

	public UIEventListener ThumbnailBtn;

	public Transform Thumbnail;

	public Transform[] PlaceHolders;

	public const float Width = 18f;

	public const float Height = 13f;

	protected override void DoInit()
	{
	}

	private void handleThumbnailClicked(GameObject btn)
	{
	}

	protected override void DoPrepare()
	{
	}

	public void AttachEventHandler()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetIndex(int index)
	{
	}
}
