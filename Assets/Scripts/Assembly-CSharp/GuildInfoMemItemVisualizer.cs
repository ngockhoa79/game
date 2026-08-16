using UnityEngine;

public class GuildInfoMemItemVisualizer : IceUIReusableList<GuildMemberInfo>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, GuildMemberInfo _meminfo)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
