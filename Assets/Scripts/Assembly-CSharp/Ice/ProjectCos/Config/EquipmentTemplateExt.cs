using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class EquipmentTemplateExt : EquipmentTemplate
	{
		public EquipTextTemplate TextTemplate { get; private set; }

		public ERarity Rarity => default(ERarity);

		public EGearSlot Part => default(EGearSlot);

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}
	}
}
