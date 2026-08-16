using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class MakyouPlayoffBattleReportIntent : IceUIIntent
	{
		private const string IntentKeyword = "MakyouPlayoffBattleReport";

		private List<CrossPersonPlayOffBattleReportProto.ReportItemProto> BattleReports;

		public MakyouPlayoffBattleReportIntent(List<CrossPersonPlayOffBattleReportProto.ReportItemProto> reports)
		{
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void ClearPanelData()
		{
		}

		public override void DoDispose()
		{
		}
	}
}
