using UnityEngine;

namespace Spine36.Unity
{
	[ExecuteInEditMode]
	[AddComponentMenu("Spine/Point Follower")]
	public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, IHasSkeletonComponent
	{
		[SerializeField]
		public SkeletonRenderer skeletonRenderer;

		[SpineSlot(null, "skeletonRenderer", false, true, false)]
		public string slotName;

		[SpineAttachment(true, false, false, "slotName", "skeletonRenderer", null, true, true)]
		public string pointAttachmentName;

		public bool followRotation;

		public bool followSkeletonFlip;

		public bool followSkeletonZPosition;

		private Transform skeletonTransform;

		private bool skeletonTransformIsParent;

		private PointAttachment point;

		private Bone bone;

		private bool valid;

		public SkeletonRenderer SkeletonRenderer => null;

		public ISkeletonComponent SkeletonComponent => null;

		public bool IsValid => false;

		public void Initialize()
		{
		}

		private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer)
		{
		}

		private void UpdateReferences()
		{
		}

		public void LateUpdate()
		{
		}
	}
}
