namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class DataModelBase
	{
		protected bool _isDirty;

		public bool IsDirty => false;

		protected void SetDirty()
		{
		}

		public void CleanDirty()
		{
		}
	}
}
