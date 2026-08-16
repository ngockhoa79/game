namespace Spine36
{
	public class Bone : IUpdatable
	{
		public static bool yDown;

		internal BoneData data;

		internal Skeleton skeleton;

		internal Bone parent;

		internal ExposedList<Bone> children;

		internal float x;

		internal float y;

		internal float rotation;

		internal float scaleX;

		internal float scaleY;

		internal float shearX;

		internal float shearY;

		internal float ax;

		internal float ay;

		internal float arotation;

		internal float ascaleX;

		internal float ascaleY;

		internal float ashearX;

		internal float ashearY;

		internal bool appliedValid;

		internal float a;

		internal float b;

		internal float worldX;

		internal float c;

		internal float d;

		internal float worldY;

		internal bool sorted;

		public BoneData Data => null;

		public Skeleton Skeleton => null;

		public Bone Parent => null;

		public ExposedList<Bone> Children => null;

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

		public float ShearX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ShearY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AppliedRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AScaleX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AScaleY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AShearX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AShearY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float A => 0f;

		public float B => 0f;

		public float C => 0f;

		public float D => 0f;

		public float WorldX => 0f;

		public float WorldY => 0f;

		public float WorldRotationX => 0f;

		public float WorldRotationY => 0f;

		public float WorldScaleX => 0f;

		public float WorldScaleY => 0f;

		public float WorldToLocalRotationX => 0f;

		public float WorldToLocalRotationY => 0f;

		public Bone(BoneData data, Skeleton skeleton, Bone parent)
		{
		}

		public void Update()
		{
		}

		public void UpdateWorldTransform()
		{
		}

		public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY)
		{
		}

		public void SetToSetupPose()
		{
		}

		internal void UpdateAppliedTransform()
		{
		}

		public void WorldToLocal(float worldX, float worldY, out float localX, out float localY)
		{
			localX = default(float);
			localY = default(float);
		}

		public void LocalToWorld(float localX, float localY, out float worldX, out float worldY)
		{
			worldX = default(float);
			worldY = default(float);
		}

		public float WorldToLocalRotation(float worldRotation)
		{
			return 0f;
		}

		public float LocalToWorldRotation(float localRotation)
		{
			return 0f;
		}

		public void RotateWorld(float degrees)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
