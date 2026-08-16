using UnityEngine;

public class ConvoyReportVisualizer : IceUIReusableList<ConvoyReportItemInfo>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, ConvoyReportItemInfo data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
