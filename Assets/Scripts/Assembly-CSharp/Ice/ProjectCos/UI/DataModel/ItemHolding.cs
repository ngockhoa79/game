namespace Ice.ProjectCos.UI.DataModel
{
	public class ItemHolding : ThingHolding
	{
		private bool mIsNew;

		private bool mIsFirstGet;

		public bool CartStatus;

		public AbstractItem Item
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public virtual int SellingPrice { get; set; }

		public bool IsNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsFirstGet
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ItemHolding(AbstractItem item, int localID, int count = 1)
			: base(null, count, localID)
		{
			LocalID = localID;
			Count = count;
		}

		public override void AddToMe()
		{
		}
	}
}
