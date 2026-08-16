namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class AbstractBuff
	{
		public string Name { get; private set; }

		public EAttrType AttrType { get; private set; }

		public AbstractBuff(string name, EAttrType attrType)
		{
		}

		public abstract float GetIncrement(float baseValue);
	}
}
