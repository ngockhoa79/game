namespace Ice.ProjectCos.UI.DataModel
{
	public class Attribute
	{
		public readonly EAttrType AttrType;

		public int BaseValue;

		public int Multiplier;

		public int AdditionValue;

		public string Name => AttrType.ToString();

		public virtual int Value => (int)((BaseValue + AdditionValue) * (1.0 + Multiplier / 10000.0));

		private bool verifyBuff(AbstractBuff buff)
		{
			return false;
		}

		public Attribute(EAttrType attrType)
		{
			AttrType = attrType;
		}
	}
}
