using System.Collections.Generic;

namespace Spine
{
	public class SkeletonData
	{
		private SkeletonAnimation skeletonAnimation;

		private SkeletonJsonData jsonData;

		internal string name;

		internal List<Skin> skins;

		internal Skin defaultSkin;

		internal List<BoneData> bones => null;

		internal List<SlotData> slots => null;

		internal List<EventData> events => null;

		internal List<Animation> animations => null;

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

		public List<BoneData> Bones => null;

		public List<SlotData> Slots => null;

		public List<Skin> Skins
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Skin DefaultSkin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<EventData> Events => null;

		public List<Animation> Animations => null;

		public SkeletonData(SkeletonJsonData _jsonData)
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

		public SlotData FindSlot(string slotName)
		{
			return null;
		}

		public int FindSlotIndex(string slotName)
		{
			return 0;
		}

		public void AddSkin(Skin skin)
		{
		}

		public Skin FindSkin(string skinName)
		{
			return null;
		}

		public EventData FindEvent(string eventDataName)
		{
			return null;
		}

		public Animation FindAnimation(string animationName)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
