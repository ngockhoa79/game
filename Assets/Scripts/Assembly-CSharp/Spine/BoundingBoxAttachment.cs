namespace Spine
{
	public class BoundingBoxAttachment : Attachment
	{
		public float[] Vertices { get; set; }

		public BoundingBoxAttachment(string name)
			: base(null)
		{
		}

		public void ComputeWorldVertices(float x, float y, Bone bone, float[] worldVertices)
		{
		}
	}
}
