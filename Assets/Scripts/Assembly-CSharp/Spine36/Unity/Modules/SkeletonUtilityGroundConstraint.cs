using UnityEngine;

namespace Spine36.Unity.Modules
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(SkeletonUtilityBone))]
	public class SkeletonUtilityGroundConstraint : SkeletonUtilityConstraint
	{
		[Tooltip("LayerMask for what objects to raycast against")]
		public LayerMask groundMask;

		[Tooltip("Use 2D")]
		public bool use2D;

		[Tooltip("Uses SphereCast for 3D mode and CircleCast for 2D mode")]
		public bool useRadius;

		[Tooltip("The Radius")]
		public float castRadius;

		[Tooltip("How high above the target bone to begin casting from")]
		public float castDistance;

		[Tooltip("X-Axis adjustment")]
		public float castOffset;

		[Tooltip("Y-Axis adjustment")]
		public float groundOffset;

		[Tooltip("How fast the target IK position adjusts to the ground.  Use smaller values to prevent snapping")]
		public float adjustSpeed;

		private Vector3 rayOrigin;

		private Vector3 rayDir;

		private float hitY;

		private float lastHitY;

		protected override void OnEnable()
		{
		}

		public override void DoUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
