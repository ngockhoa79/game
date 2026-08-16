using System;
using System.Xml;

namespace Ice.ProjectCos.UI.Util
{
	public static class XmlX
	{
		private static readonly Logger logger;

		public static string GetPath(this XmlNode node)
		{
			return null;
		}

		public static string GetStrAttr(this XmlNode node, string attrName, string defaultValue = null)
		{
			return null;
		}

		public static int GetIntAttr(this XmlNode node, string attrName, int defaultValue = -1)
		{
			return 0;
		}

		public static float GetFloatAttr(this XmlNode node, string attrName, float defaultValue = 0f)
		{
			return 0f;
		}

		public static int[] GetIntArrayAttr(this XmlNode node, string attrName, int[] defaultValue = null)
		{
			return null;
		}

		public static int GetIntInnerValue(this XmlNode node, int defaultValue = -1)
		{
			return 0;
		}

		public static int[] GetIntArrayInnerValue(this XmlNode node, string childNodeName, Func<int, string> verifier = null, int[] defaultValue = null, bool continueOnError = false)
		{
			return null;
		}
	}
}
