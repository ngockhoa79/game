using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class SkeletonJsonData
	{
		[ProtoMember(1)]
		internal List<BoneData> bones;

		[ProtoMember(2)]
		internal List<SlotData> slots;

		[ProtoMember(3)]
		internal List<EventData> events;

		[ProtoMember(4)]
		internal List<Animation> animations;

		public List<BoneData> Bones => null;

		public List<SlotData> Slots => null;

		public List<EventData> Events
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Animation> Animations
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddBone(BoneData bone)
		{
		}

		public BoneData FindBone(string boneName)
		{
			return null;
		}

		public int FindBoneIndex(string boneName)
		{
			return 0;
		}

		public void AddSlot(SlotData slot)
		{
		}

		public SlotData FindSlot(string slotName)
		{
			return null;
		}

		public int FindSlotIndex(string slotName)
		{
			return 0;
		}

		public void AddEvent(EventData eventData)
		{
		}

		public EventData FindEvent(string eventDataName)
		{
			return null;
		}

		public void AddAnimation(Animation animation)
		{
		}

		public Animation FindAnimation(string animationName)
		{
			return null;
		}
	}
}
