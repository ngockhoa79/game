using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class HeroLevelTemplateExt : HeroLevelTemplate
	{
		private int[] exps_;

		public override void Init()
		{
		}

		public int GetExp(int expId)
		{
			return 0;
		}

		public static bool IsCorrectExpType(int expType)
		{
			return false;
		}
	}
}
