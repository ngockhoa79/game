namespace Ice.ProjectCos.UI.DataModel
{
	public class UpgradableAbsValueBuff : AbstractBuff
	{
		public float BaseIncrement { get; private set; }

		public float PerLevelIncrement { get; private set; }

		public float MaxIncrement { get; private set; }

		public int Level { get; private set; }

		public UpgradableAbsValueBuff(string name, EAttrType attrType, float baseInc, float perLevelInc, float maxInc, int level)
			: base(null, default(EAttrType))
		{
		}

		public override float GetIncrement(float baseValue)
		{
			return 0f;
		}

		public float CalcIncrement(int level)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
