using System;

namespace Mono.Xml
{
	internal class SmallXmlParserException : SystemException
	{
		private int line;

		private int column;

		public int Line => 0;

		public int Column => 0;

		public SmallXmlParserException(string msg, int line, int column)
		{
		}
	}
}
