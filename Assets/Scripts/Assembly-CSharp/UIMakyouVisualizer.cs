using Ice.ProjectCos.Protocol;
using UnityEngine;

internal class UIMakyouVisualizer : IceUIReusableList<CrossPersonPlayOffBetRankingProto.RankingItemProto>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, CrossPersonPlayOffBetRankingProto.RankingItemProto data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
