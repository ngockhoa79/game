using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class AttachmentTimeline : Timeline
	{
		[ProtoMember(1)]
		internal int slotIndex;

		[ProtoMember(2)]
		internal float[] frames;

		[ProtoMember(3)]
		private string[] attachmentNames;

		public int SlotIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float[] Frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] AttachmentNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FrameCount => 0;

		public AttachmentTimeline()
		{
		}

		public AttachmentTimeline(int frameCount)
		{
		}

		public void setFrame(int frameIndex, float time, string attachmentName)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}
