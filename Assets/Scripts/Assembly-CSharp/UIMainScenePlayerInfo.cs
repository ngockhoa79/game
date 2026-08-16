using Ice.ProjectCos.UI.DataModel;
using System;

public class UIMainScenePlayerInfo : IceUIBase
{
	public UILabel lbLevel;

	public UILabel lbFightValue;

	public UILabel lbPlayerName;

	public UILabel lbVipLevel;

	public UIEventListener btnVip;

	public UISprite spLevelRatio;

	public Action E_OnVip;

	protected override void DoPrepare()
	{
		InitPanel();
		PlayerData();
	}

	protected override void DoClearData()
	{
	}

	private void InitPanel()
	{
		PlayerData();
	}

	private void ClearPanel()
	{
	}

	private void Update()
	{
	}

	public void PlayerData()
	{
		if (Me.Ins == null) return;
		if (lbLevel != null)
		{
			lbLevel.text = Me.Ins.Level.ToString();
		}
		if (lbPlayerName != null)
		{
			lbPlayerName.text = !string.IsNullOrEmpty(Me.Ins.Name) ? Me.Ins.Name : "Player";
		}
		if (lbFightValue != null)
		{
			// [RECOVERED]
			lbFightValue.text = Me.Ins.Power.ToString();
		}
		if (lbVipLevel != null)
		{
			// [RECOVERED]
			lbVipLevel.text = Me.Ins.VIPLevel.ToString();
		}
	}
}
