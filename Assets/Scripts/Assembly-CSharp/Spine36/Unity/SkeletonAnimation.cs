using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine36.Unity
{
	[AddComponentMenu("Spine/SkeletonAnimation")]
	[HelpURL("http://esotericsoftware.com/spine-unity-documentation#Controlling-Animation")]
	[ExecuteInEditMode]
	public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, IAnimationStateComponent
	{
		public AnimationState state;

		[SpineAnimation(null, null, true, false)]
		[SerializeField]
		private string _animationName;

		public bool loop;

		public float timeScale;

		public AnimationState AnimationState => null;

		public string AnimationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateLocal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateWorld
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateLocal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateWorld
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		private TrackEntry TrySetAnimation(string animationName, bool animationLoop)
		{
			return null;
		}

		public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}

		public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}

		public override void ClearState()
		{
		}

		public override void Initialize(bool overwrite)
		{
		}

		private void Update()
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}
