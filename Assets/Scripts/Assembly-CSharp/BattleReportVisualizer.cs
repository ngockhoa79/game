using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BattleReportVisualizer : IceUIReusableList<RankingBattleReportProto.ReportItemProto>.IVisualizer
{
	private const string ItemPrefab = "BattleReportItem";

	private const string ResCategory = "uiarena";

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, RankingBattleReportProto.ReportItemProto data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
