namespace Ice.ProjectCos.UI.DataModel
{
	public class NotifySkillFragCanCombine : INotifyEvent
	{
		private bool HasSkillCanCombine => false;

		public override bool CheckStatus()
		{
			return false;
		}
	}
}
