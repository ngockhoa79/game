namespace Spine
{
	public class FullSkeletonJson
	{
		private AttachmentLoader attachmentLoader;

		private object obj;

		private object obj2;

		public float Scale { get; set; }

		public FullSkeletonJson(Atlas atlas)
		{
		}

		public FullSkeletonJson(AttachmentLoader attachmentLoader)
		{
		}

		private void ProcessStartObject(SkeletonData skeletonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessReadObject(SkeletonData skeletonData, string[] propertyStack, int propertyIndex, string content)
		{
		}

		private void ProcessEndObject(SkeletonData skeletonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessStartArray(SkeletonData skeletonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessEndArray(SkeletonData skeletonData, string[] propertyStack, int propertyIndex)
		{
		}

		public void ReadSkeletonData(SkeletonData skeletonData, string reader)
		{
		}

		public void ReadSkeletonDataFinished(SkeletonData skeletonData)
		{
		}

		public static float ToColor(string hexString, int colorIndex)
		{
			return 0f;
		}
	}
}
