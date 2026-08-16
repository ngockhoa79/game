using System;
using UnityEngine;

public class UIBulletinPanel : IceUIBase
{
	public UIEventListener PanelClick;

	public UIWidget BGPanel;

	public BoxCollider collisionBox;

	public int BaseWidth;

	public int BaseHeight;

	protected int trackLength;

	public Action E_OnPanelClick;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void OnPanelClick(GameObject go)
	{
	}

	public void SetPanelWidthHeight(int panelWidth, int panelHeight)
	{
	}

	public int GetMessageCount()
	{
		return 0;
	}
}
