using System;
using System.Collections;
using System.Text;

namespace Mono.Xml
{
	internal class MiniParser
	{
		public interface IReader
		{
			int Read();
		}

		public interface IAttrList
		{
			int Length { get; }

			bool IsEmpty { get; }

			string[] Names { get; }

			string[] Values { get; }

			string GetName(int i);

			string GetValue(int i);

			string GetValue(string name);

			void ChangeValue(string name, string newValue);
		}

		public interface IMutableAttrList : IAttrList
		{
			void Clear();

			void Add(string name, string value);

			void CopyFrom(IAttrList attrs);

			void Remove(int i);

			void Remove(string name);
		}

		public interface IHandler
		{
			void OnStartParsing(MiniParser parser);

			void OnStartElement(string name, IAttrList attrs);

			void OnEndElement(string name);

			void OnChars(string ch);

			void OnEndParsing(MiniParser parser);
		}

		public class HandlerAdapter : IHandler
		{
			public void OnStartParsing(MiniParser parser)
			{
			}

			public void OnStartElement(string name, IAttrList attrs)
			{
			}

			public void OnEndElement(string name)
			{
			}

			public void OnChars(string ch)
			{
			}

			public void OnEndParsing(MiniParser parser)
			{
			}
		}

		private enum CharKind : byte
		{
			LEFT_BR = 0,
			RIGHT_BR = 1,
			SLASH = 2,
			PI_MARK = 3,
			EQ = 4,
			AMP = 5,
			SQUOTE = 6,
			DQUOTE = 7,
			BANG = 8,
			LEFT_SQBR = 9,
			SPACE = 10,
			RIGHT_SQBR = 11,
			TAB = 12,
			CR = 13,
			EOL = 14,
			CHARS = 15,
			UNKNOWN = 31
		}

		private enum ActionCode : byte
		{
			START_ELEM = 0,
			END_ELEM = 1,
			END_NAME = 2,
			SET_ATTR_NAME = 3,
			SET_ATTR_VAL = 4,
			SEND_CHARS = 5,
			START_CDATA = 6,
			END_CDATA = 7,
			ERROR = 8,
			STATE_CHANGE = 9,
			FLUSH_CHARS_STATE_CHANGE = 10,
			ACC_CHARS_STATE_CHANGE = 11,
			ACC_CDATA = 12,
			PROC_CHAR_REF = 13,
			UNKNOWN = 15
		}

		public class AttrListImpl : IMutableAttrList, IAttrList
		{
			protected ArrayList names;

			protected ArrayList values;

			public int Length => 0;

			public bool IsEmpty => false;

			public string[] Names => null;

			public string[] Values => null;

			public AttrListImpl()
			{
			}

			public AttrListImpl(int initialCapacity)
			{
			}

			public AttrListImpl(IAttrList attrs)
			{
			}

			public string GetName(int i)
			{
				return null;
			}

			public string GetValue(int i)
			{
				return null;
			}

			public string GetValue(string name)
			{
				return null;
			}

			public void ChangeValue(string name, string newValue)
			{
			}

			public void Clear()
			{
			}

			public void Add(string name, string value)
			{
			}

			public void Remove(int i)
			{
			}

			public void Remove(string name)
			{
			}

			public void CopyFrom(IAttrList attrs)
			{
			}
		}

		public class XMLError : Exception
		{
			protected string descr;

			protected int line;

			protected int column;

			public int Line => 0;

			public int Column => 0;

			public XMLError()
			{
			}

			public XMLError(string descr)
			{
			}

			public XMLError(string descr, int line, int column)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private static readonly int INPUT_RANGE;

		private static readonly ushort[] tbl;

		protected static string[] errors;

		protected int line;

		protected int col;

		protected int[] twoCharBuff;

		protected bool splitCData;

		public void Reset()
		{
		}

		protected static bool StrEquals(string str, StringBuilder sb, int sbStart, int len)
		{
			return false;
		}

		protected void FatalErr(string descr)
		{
		}

		protected static int Xlat(int charCode, int state)
		{
			return 0;
		}

		public void Parse(IReader reader, IHandler handler)
		{
		}
	}
}
