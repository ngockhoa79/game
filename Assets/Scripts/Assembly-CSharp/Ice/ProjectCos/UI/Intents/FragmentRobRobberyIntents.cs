using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class FragmentRobRobberyIntents : IceUIIntent
	{
		private const string IntentKeyword = "FragmentRob";

		private SkillFragment _skillFragment;

		private S2CRobberyOpponentsAck.TargetInfoProto[] _snapshots;

		private Dictionary<ulong, Player> _playerInfoCache;

		public FragmentRobRobberyIntents(SkillFragment fragment, S2CRobberyOpponentsAck.TargetInfoProto[] snapshots)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void StartShowFragmentRobberyConfirmIntent(S2CRobberyOpponentsAck.TargetInfoProto snapShot)
		{
		}

		private void ShowConfirmIntent(Player player)
		{
		}

		private void RefreshOppnent(object response)
		{
		}
	}
}
