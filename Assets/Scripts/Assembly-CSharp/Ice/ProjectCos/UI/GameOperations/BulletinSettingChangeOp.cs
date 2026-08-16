namespace Ice.ProjectCos.UI.GameOperations
{
	public class BulletinSettingChangeOp : Operation
	{
		private bool BulletinOn;

		public bool Succeeded;

		public bool SwitchResult;

		public BulletinSettingChangeOp(bool isOn)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
