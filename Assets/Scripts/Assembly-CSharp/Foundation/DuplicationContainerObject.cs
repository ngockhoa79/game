using System.Collections.Generic;
using UnityEngine;

namespace Foundation
{
	public class DuplicationContainerObject
	{
		private class SubDuplicationContainerObject
		{
			private Dictionary<string, Object> _dic;

			public int Count => 0;

			public void Set(string key, Object val)
			{
			}

			public bool Remove(string key)
			{
				return false;
			}

			public void RemoveAll()
			{
			}

			public Object Get(string key)
			{
				return null;
			}

			public IEnumerable<string> GetKeys()
			{
				return null;
			}

			public IEnumerable<Object> GetAll()
			{
				return null;
			}
		}

		private Dictionary<string, SubDuplicationContainerObject> _dic;

		public void Set(string key1, string key2, Object val)
		{
		}

		public Object Get(string key1, string key2)
		{
			return null;
		}

		public bool Remove(string key1, string key2)
		{
			return false;
		}

		public IEnumerable<Object> GetAll()
		{
			return null;
		}

		public List<Tuple<string, string>> GetAllKeys()
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		private void ShowLogs()
		{
		}
	}
}
