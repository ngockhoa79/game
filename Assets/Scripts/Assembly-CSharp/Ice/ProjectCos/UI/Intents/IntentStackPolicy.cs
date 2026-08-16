using System;
using System.Collections.Generic;

namespace Ice.ProjectCos.UI.Intents
{
	public static class IntentStackPolicy
	{
		public static void ReplaceStackList(List<IntentStackPolicyContent> list, Action callback)
		{
		}

		public static void AppendStackList(List<IntentStackPolicyContent> list, Action callback)
		{
		}

		public static void OnOpenDuplication(int duplicationId)
		{
		}

		private static Intent AppendStack(IntentStackPolicyContent content, Action callback, bool playEnterEffect, bool playExitEffect, Intent parentIntent = null)
		{
			return null;
		}
	}
}
