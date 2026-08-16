namespace Spine
{
	public class Bone
	{
		public static bool yDown;

		internal BoneData data;

		internal Bone parent;

		internal float x;

		internal float y;

		internal float rotation;

		internal float scaleX;

		internal float scaleY;

		internal float m00;

		internal float m01;

		internal float m10;

		internal float m11;

		internal float worldX;

		internal float worldY;

		internal float worldRotation;

		internal float worldScaleX;

		internal float worldScaleY;

		public BoneData Data => null;

		public Bone Parent => null;

		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float M00 => 0f;

		public float M01 => 0f;

		public float M10 => 0f;

		public float M11 => 0f;

		public float WorldX => 0f;

		public float WorldY => 0f;

		public float WorldRotation => 0f;

		public float WorldScaleX => 0f;

		public float WorldScaleY => 0f;

		public Bone(BoneData data, Bone parent)
		{
		}

		public void UpdateWorldTransform(bool flipX, bool flipY)
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
