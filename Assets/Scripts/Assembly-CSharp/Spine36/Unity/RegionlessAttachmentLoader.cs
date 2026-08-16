namespace Spine36.Unity
{
	public class RegionlessAttachmentLoader : AttachmentLoader
	{
		private static AtlasRegion emptyRegion;

		private static AtlasRegion EmptyRegion => null;

		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
		{
			return null;
		}

		public PathAttachment NewPathAttachment(Skin skin, string name)
		{
			return null;
		}

		public PointAttachment NewPointAttachment(Skin skin, string name)
		{
			return null;
		}

		public ClippingAttachment NewClippingAttachment(Skin skin, string name)
		{
			return null;
		}
	}
}
