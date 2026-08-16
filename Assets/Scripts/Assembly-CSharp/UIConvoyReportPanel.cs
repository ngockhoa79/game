using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoyReportPanel : UIConvoyPopupBase
{
	[SerializeField]
	private UIEventListener closeButton;

	public UIConvoyReportList ReportList;

	public UITable Table;

	public int ReportComparer(WrestBattleInfo reportA, WrestBattleInfo reportB)
	{
		return 0;
	}

	public void SetDetail(List<WrestBattleInfo> reports)
	{
	}

	protected override void SetID()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void onClose(GameObject btn)
	{
	}

	public override void ClosePanel()
	{
	}
}
