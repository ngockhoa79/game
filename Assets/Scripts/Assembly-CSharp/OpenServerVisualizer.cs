using UnityEngine;

public class OpenServerVisualizer : IceUIReusableList<OpenServerElement>.IVisualizer
{
	private const string ItemPrefab = "item_opencelebrate";

	private const string ResCategory = "uiopenserver";

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, OpenServerElement e)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
