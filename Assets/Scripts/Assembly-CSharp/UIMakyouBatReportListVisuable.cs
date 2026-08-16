using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

internal class UIMakyouBatReportListVisuable : IceUIReusableList<MakyouBatterReportItemStruct>.IVisualizer
{
	public UIMakyouBatterReport owner;

	public UIMakyouBatReportListVisuable(UIMakyouBatterReport parent)
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, MakyouBatterReportItemStruct data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
