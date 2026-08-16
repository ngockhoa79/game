namespace Ice.ProjectCos.Config
{
	public struct CombatValueBuilder
	{
		public struct MajorProperty
		{
			public int Base;

			public int Current;

			public int Max;

			public int Value => 0;

			public void SetAllSame(int value)
			{
			}
		}

		public int BaseLevel;

		public int MaxLevel;

		public MajorProperty Hp;

		public MajorProperty Attack;

		public MajorProperty Defense;

		public MajorProperty Spirit;

		public int Crit;

		public int AntiCrit;

		public int Batter;

		public int AntiBatter;

		public int Miss;

		public int AntiMiss;

		public int Block;

		public int AntiBlock;

		public int Speed;

		public double SkillsCombatValue;

		public double Build()
		{
			return 0.0;
		}
	}
}
