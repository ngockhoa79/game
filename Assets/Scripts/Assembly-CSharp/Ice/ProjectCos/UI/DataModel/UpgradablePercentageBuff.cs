namespace Ice.ProjectCos.UI.DataModel
{
	public class UpgradablePercentageBuff : AbstractBuff
	{
		public float BaseIncrement { get; private set; }

		public float PerLevelIncrement { get; private set; }

		public float MaxIncrement { get; private set; }

		public int Level { get; private set; }

		public UpgradablePercentageBuff(string name, EAttrType attrType, float baseInc, float perLevelInc, float maxInc, int level)
			: base(null, default(EAttrType))
		{
		}

		public override float GetIncrement(float baseValue)
		{
			return 0f;
		}

		public float CalcIncrementPercentage(int level)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
