using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

internal class UIMakyouRewardListVisualizer : IceUIReusableList<CrossPersonRankBonusTemplate>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, CrossPersonRankBonusTemplate data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
