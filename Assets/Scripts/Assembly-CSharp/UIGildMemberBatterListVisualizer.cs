using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGildMemberBatterListVisualizer : IceUIReusableList<CrossGuildBattleResultStruct>.IVisualizer
{
	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, CrossGuildBattleResultStruct data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
