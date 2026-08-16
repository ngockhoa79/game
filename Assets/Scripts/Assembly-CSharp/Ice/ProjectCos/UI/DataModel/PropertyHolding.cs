namespace Ice.ProjectCos.UI.DataModel
{
	public class PropertyHolding : ThingHolding
	{
		public PropertyThing PropertyItem
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public PropertyHolding(PropertyThing pthing, int count)
			: base(null, 0, 0)
		{
		}

		public override void AddToMe()
		{
		}
	}
}
