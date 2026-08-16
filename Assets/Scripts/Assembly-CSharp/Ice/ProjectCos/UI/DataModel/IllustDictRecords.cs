using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class IllustDictRecords
	{
		public enum RecordType
		{
			Coser = 0,
			Gear = 1,
			Skill = 2,
			Item = 3
		}

		private List<int> CoserRecords;

		private List<int> GearRecords;

		private List<int> SkillRecords;

		private List<int> ItemRecords;

		private List<int> IgnoreList;

		public void BuildFromProto(ThingRecordsProto rawProto)
		{
		}

		public void Clear()
		{
		}

		public void AddRecord(ItemHolding new_item)
		{
		}

		public bool IsItemUnlocked(RecordType itemType, int itemID)
		{
			return false;
		}

		public int GetRecordsCount()
		{
			return 0;
		}
	}
}
