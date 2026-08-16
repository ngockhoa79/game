using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ShopAwardData
	{
		public List<ShopAwardName_Thing> AwardList;

		public int ID { get; private set; }

		public string AwardOhterText { get; private set; }

		public int RankFrom { get; private set; }

		public int RankTo { get; private set; }

		public void CrateFormPvpShop(int shopID)
		{
		}

		public void CreateFromGuildShop(int shopID)
		{
		}

		public void CrateFormTrailGurad(int rankFrom, int rankTo)
		{
		}

		public void CrateFormTrailBoss(int rank)
		{
		}

		public string GetTitleString()
		{
			return null;
		}

		public string GetGuildIndexString()
		{
			return null;
		}

		public string GetPVPIndexString()
		{
			return null;
		}

		public string GetPVPTitleString()
		{
			return null;
		}
	}
}
