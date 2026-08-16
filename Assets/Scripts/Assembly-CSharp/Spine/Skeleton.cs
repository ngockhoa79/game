using System.Collections.Generic;

namespace Spine
{
	public class Skeleton
	{
		internal SkeletonData data;

		internal List<Bone> bones;

		internal List<Slot> slots;

		internal List<Slot> drawOrder;

		internal Skin skin;

		internal float r;

		internal float g;

		internal float b;

		internal float a;

		internal float time;

		internal bool flipX;

		internal bool flipY;

		internal float x;

		internal float y;

		private Dictionary<string, Animation> selfAnimation;

		public SkeletonData Data => null;

		public List<Bone> Bones => null;

		public List<Slot> Slots => null;

		public List<Slot> DrawOrder => null;

		public Skin Skin
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

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool FlipX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool FlipY
		{
			get
			{
				return false;
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

		public Bone RootBone => null;

		public void Dispose()
		{
		}

		public void ReadAnimation(SkeletonDataAsset dataAsset, bool readBattleAnimation, bool readUIAnimation)
		{
		}

		public Animation TryGetSelfAnimation(string animationName)
		{
			return null;
		}

		public Skeleton(SkeletonData data)
		{
		}

		private bool __list_contains__(List<BoneData> boneDataList, BoneData boneData)
		{
			return false;
		}

		private int __get_bone_index_from_name__(SkeletonData data, BoneData boneData)
		{
			return 0;
		}

		public void UpdateWorldTransform()
		{
		}

		public void SetToSetupPose()
		{
		}

		public void SetBonesToSetupPose()
		{
		}

		public void SetSlotsToSetupPose()
		{
		}

		public Bone FindBone(string boneName)
		{
			return null;
		}

		public int FindBoneIndex(string boneName)
		{
			return 0;
		}

		public Slot FindSlot(string slotName)
		{
			return null;
		}

		public int FindSlotIndex(string slotName)
		{
			return 0;
		}

		public void SetSkin(string skinName)
		{
		}

		public void SetSkin(Skin newSkin)
		{
		}

		public Attachment GetAttachment(string slotName, string attachmentName)
		{
			return null;
		}

		public Attachment GetAttachment(int slotIndex, string attachmentName)
		{
			return null;
		}

		public void SetAttachment(string slotName, string attachmentName)
		{
		}

		public void Update(float delta)
		{
		}
	}
}
