using System;

namespace Ice.ProjectCos.ConfigGenerator.Xml
{
	internal static class GeneratorUtility
	{
		public static int Get(ConfigElement element, string name, int _)
		{
			return 0;
		}

		public static double Get(ConfigElement element, string name, double _)
		{
			return 0.0;
		}

		public static string Get(ConfigElement element, string name, string _)
		{
			return null;
		}

		public static T Get<T>(ConfigElement element, string name, T _) where T : IGeneratorObject, new()
		{
			return default(T);
		}

		public static int[] GetArray(ConfigElement element, string itemName, int _)
		{
			return null;
		}

		public static double[] GetArray(ConfigElement element, string itemName, double _)
		{
			return null;
		}

		public static string[] GetArray(ConfigElement element, string itemName, string _)
		{
			return null;
		}

		public static T[] GetArray<T>(ConfigElement element, string itemName, T _) where T : IGeneratorObject, new()
		{
			return null;
		}

		public static T[] Load<T>(string fileName, string itemName) where T : IGeneratorObject, new()
		{
			return null;
		}

		public static T Load<T>(string fileName) where T : IGeneratorObject, new()
		{
			return default(T);
		}

		public static T[] LoadFromXml<T>(string xml, string itemName) where T : IGeneratorObject, new()
		{
			return null;
		}

		private static T[] GetArray<T>(ConfigElement element, string itemName, T _, Func<ConfigElement, T, T> convert)
		{
			return null;
		}

		public static string GetContent(string fileName)
		{
			return null;
		}

		private static ConfigElement LoadRootFromXmlString(string xmlString)
		{
			return null;
		}

		public static int Convert(ConfigElement e, int _)
		{
			return 0;
		}

		private static double Convert(ConfigElement e, double _)
		{
			return 0.0;
		}

		private static string Convert(ConfigElement e, string _)
		{
			return null;
		}

		private static T Convert<T>(ConfigElement e, T _) where T : IGeneratorObject, new()
		{
			return default(T);
		}

		private static int Convert(string s, int _)
		{
			return 0;
		}

		private static double Convert(string s, double _)
		{
			return 0.0;
		}

		private static string Convert(string s, string _)
		{
			return null;
		}
	}
}
