using Ice.ProjectCos.Protocol;
using UnityEngine;

public class CrossPkReplayPanel : MonoBehaviour
{
	public UILabel BattleLabel;

	public UILabel LineLabel;

	public CrossPkReplayLineCtrller Line1;

	public CrossPkReplayLineCtrller Line2;

	public UIEventListener CloseBtn;

	private GuildPkLineReplayInfo info;

	public void SetData(GuildPkLineReplayInfo _info)
	{
	}

	private void tip(string t)
	{
	}

	private void OnCloseBtnClicked(GameObject _obj)
	{
	}

	private void OnLine1ReplayBtnClicked(GameObject _obj)
	{
	}

	private void OnLine2ReplayBtnClicked(GameObject _obj)
	{
	}

	private void ReplayBattle(S2CrossGuildBattleReportDetailAck _ack)
	{
	}
}
