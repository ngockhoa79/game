using UnityEngine;

public class RankListVisualizer : IceUIReusableList<PlayerSummaryInfoTiledUpWithRank>.IVisualizer
{
	private const string ItemPrefab = "RankListItem";

	private const string ResCategory = "uiarena";

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, PlayerSummaryInfoTiledUpWithRank p)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
