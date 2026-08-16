using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

internal class UIGildRewardListVisualizer : IceUIReusableList<CrossGuildSeasonRankBonusTemplate>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, CrossGuildSeasonRankBonusTemplate data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
