using System.ComponentModel;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class SlotData
	{
		[ProtoMember(1)]
		internal string name;

		[ProtoMember(2, AsReference = true)]
		internal BoneData boneData;

		[ProtoMember(3)]
		internal float r;

		[ProtoMember(4)]
		internal float g;

		[ProtoMember(5)]
		internal float b;

		[ProtoMember(6)]
		internal float a;

		[ProtoMember(7)]
		internal string attachmentName;

		[ProtoMember(8)]
		[DefaultValue(true)]
		internal bool additiveBlending;

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

		public BoneData BoneData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public string AttachmentName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AdditiveBlending
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SlotData(string name, BoneData boneData)
		{
		}

		public SlotData()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
