using UnityEngine;

public class GuildActivityVisualizer : IceUIReusableList<GuildActivityData>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, GuildActivityData data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
