using System;

namespace Ice.ProjectCos.ConfigGenerator.Xml
{
	public static class GeneratorConfig
	{
		public static string ConfigDir;

		internal static Action DelayInitAction;

		public static void InvokeDelayInitAction()
		{
		}
	}
}
