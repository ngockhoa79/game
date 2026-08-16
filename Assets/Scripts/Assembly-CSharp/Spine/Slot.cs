namespace Spine
{
	public class Slot
	{
		internal SlotData data;

		internal Bone bone;

		internal Skeleton skeleton;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal float attachmentTime;

		internal Attachment attachment;

		public SlotData Data => null;

		public Bone Bone => null;

		public Skeleton Skeleton => null;

		public float R
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float G
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float B
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float A
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Attachment Attachment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float AttachmentTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Slot(SlotData data, Skeleton skeleton, Bone bone)
		{
		}

		internal void SetToSetupPose(int slotIndex)
		{
		}

		public void SetToSetupPose()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
