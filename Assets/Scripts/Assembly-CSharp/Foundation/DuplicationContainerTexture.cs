using System.Collections.Generic;
using UnityEngine;

namespace Foundation
{
	public class DuplicationContainerTexture
	{
		private class SubDuplicationContainerTexture
		{
			private Dictionary<string, Texture> _dic;

			public int Count => 0;

			public void Set(string key, Texture val)
			{
			}

			public bool Remove(string key)
			{
				return false;
			}

			public void RemoveAll()
			{
			}

			public Texture Get(string key)
			{
				return null;
			}

			public IEnumerable<string> GetKeys()
			{
				return null;
			}

			public IEnumerable<Texture> GetAll()
			{
				return null;
			}
		}

		private Dictionary<string, SubDuplicationContainerTexture> _dic;

		public void Set(string key1, string key2, Texture val)
		{
		}

		public Texture Get(string key1, string key2)
		{
			return null;
		}

		public bool Remove(string key1, string key2)
		{
			return false;
		}

		public IEnumerable<Texture> GetAll()
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
	}
}
