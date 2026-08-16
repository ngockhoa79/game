using UnityEngine;

namespace Ice.ProjectCos.UI.Util
{
	public class Assert
	{
		private static readonly Logger logger;

		public static string GetStackTrace(int skips)
		{
			return null;
		}

		public static void Fail(int skipStackFrames, string message, params object[] args)
		{
		}

		public static void Fail(string message, params object[] args)
		{
		}

		public static bool AssertTrue(bool expression)
		{
			return false;
		}

		public static bool AssertString(string str)
		{
			return false;
		}

		public static bool AssertSprite(UISprite sprite)
		{
			return false;
		}

		public static bool AssertInRange(int value, int min, int max)
		{
			return false;
		}

		public static bool AssertAtLeast(int value, int min)
		{
			return false;
		}

		public static bool AssertAtMost(int value, int max)
		{
			return false;
		}

		public static bool AssertNotNull(object obj)
		{
			return false;
		}

		public static bool AssertNotNull(Object obj)
		{
			return false;
		}

		public static bool AssertEquals(object value, object expectation)
		{
			return false;
		}

		public static T AssertIs<T>(object obj) where T : class
		{
			return null;
		}

		public static T AssertComponent<T>(GameObject obj) where T : Component
		{
			return null;
		}
	}
}
