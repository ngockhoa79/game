using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class ItemTemplateExt : ItemTemplate
	{
		public ItemTextTemplate TextTemplate { get; private set; }

		public new ItemType Type => default(ItemType);

		public new ERarity Rarity => default(ERarity);

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}
	}
}
