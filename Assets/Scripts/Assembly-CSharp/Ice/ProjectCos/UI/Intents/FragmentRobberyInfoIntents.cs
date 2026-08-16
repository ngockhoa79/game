using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.GameOperations;

namespace Ice.ProjectCos.UI.Intents
{
	public class FragmentRobberyInfoIntents : IceUIIntent
	{
		private const string IntentKeyword = "FragmentRobberyInfo";

		private List<RobberyReportInfoListProto.TargetInfo> _targets;

		private List<RobberyNoticeInfoListProto.FrinedInfo> _friendNotices;

		private RobberyInfoReqOp.EType _type;

		public FragmentRobberyInfoIntents(List<RobberyReportInfoListProto.TargetInfo> targets, List<RobberyNoticeInfoListProto.FrinedInfo> friendNotices, RobberyInfoReqOp.EType type)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}

		private void RemoveFromTargets(int _reportId)
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		private List<FragmentPopupContent> GetFragmentPopList()
		{
			return null;
		}

		private List<FragmentPopupNotificationContent> GetFragmentPopNotificationList()
		{
			return null;
		}
	}
}
