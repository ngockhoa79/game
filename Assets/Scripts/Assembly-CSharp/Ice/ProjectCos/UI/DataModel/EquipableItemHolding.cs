using System;
using System.Runtime.CompilerServices;

namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class EquipableItemHolding : ItemHolding
	{
		public Hero User { get; private set; }

		public event Action<ItemHolding, Hero, Hero> OnUserChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetUser(Hero user)
		{
		}

		public EquipableItemHolding(AbstractItem item, int localID, int count = 1)
			: base(null, 0, 0)
		{
		}
	}
}
