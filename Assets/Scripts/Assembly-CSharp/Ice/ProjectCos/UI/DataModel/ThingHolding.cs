using System;
using System.Runtime.CompilerServices;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ThingHolding
	{
		public bool MiMumERshi;

		protected int count;

		public Thing ThingItem { get; protected set; }

		public int LocalID { get; set; }

		public int Count
		{
			get
			{
				return count;
			}
			set
			{
				count = value;
			}
		}

		public event Action<ThingHolding, int, int> OnCountChanged
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

		public ThingHolding(Thing thing, int count, int localID = -1)
		{
		}

		public virtual void AddToMe()
		{
		}
	}
}
