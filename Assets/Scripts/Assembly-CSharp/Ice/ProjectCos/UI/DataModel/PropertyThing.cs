namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class PropertyThing : Thing
	{
		public override EItemType ItemForm => default(EItemType);

		public override string GetDetailName()
		{
			return null;
		}

		public override string GetDetailNameColored()
		{
			return null;
		}

		public override string GetNameColorTag()
		{
			return null;
		}
	}
}
