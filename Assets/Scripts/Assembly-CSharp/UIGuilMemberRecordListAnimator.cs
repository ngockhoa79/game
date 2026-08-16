using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuilMemberRecordListAnimator : IceUIReusableList<CrossGuildPlayerRankingProto.RankingItemProto>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, CrossGuildPlayerRankingProto.RankingItemProto data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
