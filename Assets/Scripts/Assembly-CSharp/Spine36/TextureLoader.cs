namespace Spine36
{
	public interface TextureLoader
	{
		void Load(AtlasPage page, string path);

		void Unload(object texture);
	}
}
