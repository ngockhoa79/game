namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class Thing
	{
		public abstract string Name { get; }

		public abstract string Desc { get; }

		public abstract string Icon { get; }

		public abstract int ID { get; }

		public abstract EItemType ItemForm { get; }

		public virtual string GetDetailName()
		{
			return null;
		}

		public virtual string GetDetailNameColored()
		{
			return null;
		}

		public virtual string GetNameColorTag()
		{
			return null;
		}

		public bool IsChip()
		{
			return false;
		}
	}
}
