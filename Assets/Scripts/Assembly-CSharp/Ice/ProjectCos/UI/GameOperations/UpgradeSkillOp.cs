using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class UpgradeSkillOp : Operation
	{
		public bool isOK;

		private SkillHolding target;

		private List<SkillHolding> sacrifices;

		private int[] stoneUsages;

		private int skillSlot;

		public SkillHolding NewSkill { get; private set; }

		public static List<SkillHolding> GetSacrifices(SkillHolding skill)
		{
			return null;
		}

		public static List<ItemHolding> GetStones(Skill skill)
		{
			return null;
		}

		public static bool IsMoneySufficient(Skill skill)
		{
			return false;
		}

		public UpgradeSkillOp(SkillHolding target, List<SkillHolding> sacrifices, int[] stoneUsages)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
