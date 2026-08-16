using System.ComponentModel;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class BoneData
	{
		[ProtoMember(1, AsReference = true)]
		internal BoneData parent;

		[ProtoMember(2)]
		internal string name;

		[ProtoMember(3)]
		internal float length;

		[ProtoMember(4)]
		internal float x;

		[ProtoMember(5)]
		internal float y;

		[ProtoMember(6)]
		internal float rotation;

		[ProtoMember(7)]
		internal float scaleX;

		[ProtoMember(8)]
		internal float scaleY;

		[ProtoMember(9)]
		[DefaultValue(true)]
		internal bool inheritScale;

		[DefaultValue(true)]
		[ProtoMember(10)]
		internal bool inheritRotation;

		public BoneData Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		public bool InheritScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InheritRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BoneData(string name, BoneData parent)
		{
		}

		public BoneData()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
