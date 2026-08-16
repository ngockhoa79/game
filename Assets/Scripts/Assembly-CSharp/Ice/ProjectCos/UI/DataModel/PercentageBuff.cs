namespace Ice.ProjectCos.UI.DataModel
{
	public class PercentageBuff : AbstractBuff
	{
		public float Increment { get; private set; }

		public PercentageBuff(string name, EAttrType attrType, float increment)
			: base(null, default(EAttrType))
		{
		}

		public override float GetIncrement(float baseValue)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
