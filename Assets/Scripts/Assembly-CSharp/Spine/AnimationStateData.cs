using System.Collections.Generic;

namespace Spine
{
	public class AnimationStateData
	{
		internal SkeletonData skeletonData;

		private Dictionary<KeyValuePair<Animation, Animation>, float> animationToMixTime;

		internal float defaultMix;

		public SkeletonData SkeletonData => null;

		public float DefaultMix
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationStateData(SkeletonData skeletonData)
		{
		}

		public void SetMix(string fromName, string toName, float duration)
		{
		}

		public void SetMix(Animation from, Animation to, float duration)
		{
		}

		public float GetMix(Animation from, Animation to)
		{
			return 0f;
		}
	}
}
