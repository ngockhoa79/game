using System;
using UnityEngine;

namespace Spine36.Unity
{
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/UI/BoneFollowerGraphic")]
	[DisallowMultipleComponent]
	public class BoneFollowerGraphic : MonoBehaviour
	{
		public SkeletonGraphic skeletonGraphic;

		public bool initializeOnAwake;

		[SpineBone(null, "skeletonGraphic", true, false)]
		[SerializeField]
		public string boneName;

		public bool followBoneRotation;

		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip;

		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		public bool followZPosition;

		[NonSerialized]
		public Bone bone;

		private Transform skeletonTransform;

		private bool skeletonTransformIsParent;

		[NonSerialized]
		public bool valid;

		public SkeletonGraphic SkeletonGraphic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SetBone(string name)
		{
			return false;
		}

		public void Awake()
		{
		}

		public void Initialize()
		{
		}

		public void LateUpdate()
		{
		}
	}
}
