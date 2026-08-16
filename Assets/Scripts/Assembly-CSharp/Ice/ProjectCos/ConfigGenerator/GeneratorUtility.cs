using System;
using System.IO;

namespace Ice.ProjectCos.ConfigGenerator
{
	internal static class GeneratorUtility
	{
		public static T[] Load<T>(string fileName, string itemName) where T : IGeneratorObject, new()
		{
			return null;
		}

		public static T Load<T>(string fileName) where T : IGeneratorObject, new()
		{
			return default(T);
		}

		private static void TryAddSubTypeTypeModel(Type type)
		{
		}

		private static void InitObj(IGeneratorObject obj)
		{
		}

		private static Stream GetContentStream(string fileName)
		{
			return null;
		}
	}
}
