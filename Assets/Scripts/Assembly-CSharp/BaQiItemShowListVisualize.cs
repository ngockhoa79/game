using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

internal class BaQiItemShowListVisualize : IceUIReusableList<CardShowItemStruct>.IVisualizer
{
	public UICardBaQiItemShow owner;

	public BaQiItemShowListVisualize(UICardBaQiItemShow parent)
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

	public void SetData(GameObject widget, CardShowItemStruct data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
