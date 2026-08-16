using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spine36.Unity
{
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/BoneFollower")]
	public class BoneFollower : MonoBehaviour
	{
		public SkeletonRenderer skeletonRenderer;

		[SerializeField]
		[SpineBone(null, "skeletonRenderer", true, false)]
		public string boneName;

		public bool followZPosition;

		public bool followBoneRotation;

		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip;

		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		[FormerlySerializedAs("resetOnAwake")]
		public bool initializeOnAwake;

		[NonSerialized]
		public bool valid;

		[NonSerialized]
		public Bone bone;

		private Transform skeletonTransform;

		private bool skeletonTransformIsParent;

		public SkeletonRenderer SkeletonRenderer
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

		public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer)
		{
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void LateUpdate()
		{
		}
	}
}
