using System.Collections.Generic;
using System.IO;

namespace Spine
{
	public class Atlas
	{
		private List<AtlasPage> pages;

		private List<AtlasRegion> regions;

		private TextureLoader textureLoader;

		public Atlas(string path, TextureLoader textureLoader)
		{
		}

		public Atlas(TextReader reader, string dir, TextureLoader textureLoader)
		{
		}

		public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions)
		{
		}

		private void Load(TextReader reader, string imagesDir, TextureLoader textureLoader)
		{
		}

		private static string readValue(TextReader reader)
		{
			return null;
		}

		private static int readTuple(TextReader reader, string[] tuple)
		{
			return 0;
		}

		public AtlasRegion FindRegion(string name)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
