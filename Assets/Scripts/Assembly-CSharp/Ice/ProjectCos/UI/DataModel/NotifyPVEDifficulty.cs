namespace Ice.ProjectCos.UI.DataModel
{
	public class NotifyPVEDifficulty : INotifyEvent
	{
		private bool bNormal;

		public NotifyPVEDifficulty(bool bNormal)
		{
		}

		public override bool CheckStatus()
		{
			return false;
		}

		public static bool CheckPVEDifficulty(bool _bNormal)
		{
			return false;
		}
	}
}
