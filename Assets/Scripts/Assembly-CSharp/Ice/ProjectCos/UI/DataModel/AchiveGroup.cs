using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class AchiveGroup
	{
		public Achive[] Achives;

		private Achive mCurentAchive;

		private int mCurrent;

		public Achive CurrentAchive => null;

		public bool IsLastAchive { get; private set; }

		public void Create(AchievementGroupProto aGroup)
		{
		}

		public void CacuCurrentAchive()
		{
		}

		public void AwardCurrentAchive()
		{
		}
	}
}
