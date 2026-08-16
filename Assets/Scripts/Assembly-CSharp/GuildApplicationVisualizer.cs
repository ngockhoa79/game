using UnityEngine;

public class GuildApplicationVisualizer : IceUIReusableList<GuildApplicationData>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, GuildApplicationData data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
