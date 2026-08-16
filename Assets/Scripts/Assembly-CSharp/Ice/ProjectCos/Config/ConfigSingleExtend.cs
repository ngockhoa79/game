using System;
using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public abstract class ConfigSingleExtend<T, T1> : ConfigSingle<T, T1> where T : ConfigSingle<T, T1>, new() where T1 : class
	{
		protected Dictionary<string, object> dict_;

		protected void Init(T1[] array, Func<T1, int> funcOfId)
		{
		}

		public T1 GetItemTemplate(int id)
		{
			return null;
		}

		public T1 TryGetItemTemplate(int id)
		{
			return null;
		}
	}
}
