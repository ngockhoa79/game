using UnityEngine;

public class CrossPkReplayLineCtrller : MonoBehaviour
{
	public CrossPkOneBlockCtrller[] Left;

	public CrossPkOneBlockCtrller[] Right;

	public CrossPkFlagCtrller center;

	public UIEventListener replayBtn;

	private GuildPkBattleResultLineInfo info;

	public void SetData(GuildPkBattleResultLineInfo _info, UIEventListener.VoidDelegate _replayClicked)
	{
	}

	private void RefreshUI()
	{
	}
}
