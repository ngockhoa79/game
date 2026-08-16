namespace Spine
{
	public class RegionAttachment : Attachment
	{
		public const int X1 = 0;

		public const int Y1 = 1;

		public const int X2 = 2;

		public const int Y2 = 3;

		public const int X3 = 4;

		public const int Y3 = 5;

		public const int X4 = 6;

		public const int Y4 = 7;

		internal float x;

		internal float y;

		internal float rotation;

		internal float scaleX;

		internal float scaleY;

		internal float width;

		internal float height;

		internal float regionOffsetX;

		internal float regionOffsetY;

		internal float regionWidth;

		internal float regionHeight;

		internal float regionOriginalWidth;

		internal float regionOriginalHeight;

		internal float[] offset;

		internal float[] uvs;

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

		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public object RendererObject { get; set; }

		public float RegionOffsetX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOffsetY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOriginalWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RegionOriginalHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float[] Offset => null;

		public float[] UVs => null;

		public RegionAttachment(string name)
			: base(null)
		{
		}

		public void SetUVs(float u, float v, float u2, float v2, bool rotate)
		{
		}

		public void UpdateOffset()
		{
		}

		public void ComputeWorldVertices(float x, float y, Bone bone, float[] vertices)
		{
		}
	}
}
