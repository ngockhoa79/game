using UnityEngine;

public class UIPVERecordReplayChild : MonoBehaviour
{
	public UILabel LblLevel;

	public UILabel LblName;

	public UIEventListener BtnReplay;

	public UIAeCardDisplayer playerPortrait;

	private BattleReport battleReport;

	private int duplicationId;

	public void SetBattleReport(BattleReportInfo info, int duplicationId)
	{
	}

	private void Start()
	{
	}
}
