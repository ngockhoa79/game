using Ice.ProjectCos.ConfigGenerator;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class RedPackTemplateExt
	{
		public class Drop : IGeneratorObject
		{
			public int Type;

			public int Id;

			public int Probability;

			public Drop(int t, int i, int p)
			{
			}

			public virtual void Init()
			{
			}

			public static implicit operator Drop(GuildRedPackTemplate.Drop o)
			{
				return null;
			}

			public static implicit operator Drop(RedPackTemplate.Drop o)
			{
				return null;
			}
		}

		public int Rank;

		public int Reputation;

		public int Contribute;

		public int Crystal;

		public int Times;

		public Drop[] Drops;

		public RedPackTemplateExt(int rank, int reputation, int contribute, int crystal, int times, Drop[] drops)
		{
		}

		public static implicit operator RedPackTemplateExt(GuildRedPackTemplate o)
		{
			return null;
		}

		public static implicit operator RedPackTemplateExt(RedPackTemplate o)
		{
			return null;
		}

		private static Drop[] getDrops(RedPackTemplate.Drop[] drops)
		{
			return null;
		}

		private static Drop[] getDrops(GuildRedPackTemplate.Drop[] drops)
		{
			return null;
		}
	}
}
