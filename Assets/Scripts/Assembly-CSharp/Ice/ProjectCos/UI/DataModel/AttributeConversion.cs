using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public static class AttributeConversion
	{
		public static void FromProto(this Attribute attr, HeroPropertyItemProto proto)
		{
			if (attr == null || proto == null) return;
			attr.BaseValue = proto.BaseValue;
			attr.Multiplier = proto.Multiplier;
			attr.AdditionValue = proto.AdditionValue;
		}

		public static void FromTemplate(this Attribute attr, HeroTemplateExt.PropertyItem propItem)
		{
			if (attr == null) return;
			attr.BaseValue = propItem.BaseValue;
			attr.AdditionValue = propItem.AdditionValue;
			attr.Multiplier = propItem.Multiplier;
		}
	}
}
