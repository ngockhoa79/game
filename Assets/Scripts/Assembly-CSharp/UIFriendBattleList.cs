using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIFriendBattleList : IceUIBase, IceUIReusableList<FriendBattleReportProto.ReportItemProto>.IVisualizer
{
	[SerializeField]
	public UIEventListener closeBtn;

	public UIFriendBattleListAnimator List;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	public void RequestList()
	{
	}

	public void SetList()
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

	public void SetData(GameObject widget, FriendBattleReportProto.ReportItemProto data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
