using UnityEngine;

public class UIPVEChapterReportItem : MonoBehaviour
{
	public UIAeCardDisplayer Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel PowerNumber;

	public UILabel GuildName;

	public UIEventListener ReplayBtn;

	private BattleReport battleReport;

	private int duplicationId;

	public void SetBattleReport(BattleReportInfo info, int duplicationId)
	{
	}

	private void Start()
	{
	}
}
