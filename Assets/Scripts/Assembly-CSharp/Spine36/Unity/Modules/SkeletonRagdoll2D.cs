using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine36.Unity.Modules
{
	[RequireComponent(typeof(SkeletonRenderer))]
	public class SkeletonRagdoll2D : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonRagdoll2D _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__32(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSmoothMixCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonRagdoll2D _003C_003E4__this;

			public float target;

			public float duration;

			private float _003CstartTime_003E5__2;

			private float _003CstartMix_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSmoothMixCoroutine_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static Transform parentSpaceHelper;

		[SpineBone(null, null, true, false)]
		[Header("Hierarchy")]
		public string startingBoneName;

		[SpineBone(null, null, true, false)]
		public List<string> stopBoneNames;

		[Header("Parameters")]
		public bool applyOnStart;

		[Tooltip("Warning!  You will have to re-enable and tune mix values manually if attempting to remove the ragdoll system.")]
		public bool disableIK;

		public bool disableOtherConstraints;

		[Space]
		[Tooltip("Set RootRigidbody IsKinematic to true when Apply is called.")]
		public bool pinStartBone;

		public float gravityScale;

		[Tooltip("If no BoundingBox Attachment is attached to a bone, this becomes the default Width or Radius of a Bone's ragdoll Rigidbody")]
		public float thickness;

		[Tooltip("Default rotational limit value.  Min is negative this value, Max is this value.")]
		public float rotationLimit;

		public float rootMass;

		[Range(0.01f, 1f)]
		[Tooltip("If your ragdoll seems unstable or uneffected by limits, try lowering this value.")]
		public float massFalloffFactor;

		[SkeletonRagdoll.LayerField]
		[Tooltip("The layer assigned to all of the rigidbody parts.")]
		public int colliderLayer;

		[Range(0f, 1f)]
		public float mix;

		private ISkeletonAnimation targetSkeletonComponent;

		private Skeleton skeleton;

		private Dictionary<Bone, Transform> boneTable;

		private Transform ragdollRoot;

		private Vector2 rootOffset;

		private bool isActive;

		public Rigidbody2D RootRigidbody { get; private set; }

		public Bone StartingBone { get; private set; }

		public Vector3 RootOffset => default(Vector3);

		public bool IsActive => false;

		public Rigidbody2D[] RigidbodyArray => null;

		public Vector3 EstimatedSkeletonPosition => default(Vector3);

		[IteratorStateMachine(typeof(_003CStart_003Ed__32))]
		private IEnumerator Start()
		{
			return null;
		}

		public void Apply()
		{
		}

		public Coroutine SmoothMix(float target, float duration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSmoothMixCoroutine_003Ed__39))]
		private IEnumerator SmoothMixCoroutine(float target, float duration)
		{
			return null;
		}

		public void SetSkeletonPosition(Vector3 worldPosition)
		{
		}

		public void Remove()
		{
		}

		public Rigidbody2D GetRigidbody(string boneName)
		{
			return null;
		}

		private void RecursivelyCreateBoneProxies(Bone b)
		{
		}

		private void UpdateSpineSkeleton(ISkeletonAnimation animatedSkeleton)
		{
		}

		private static List<Collider2D> AttachBoundingBoxRagdollColliders(Bone b, GameObject go, Skeleton skeleton, float gravityScale)
		{
			return null;
		}

		private static float GetPropagatedRotation(Bone b)
		{
			return 0f;
		}

		private static Vector3 FlipScale(bool flipX, bool flipY)
		{
			return default(Vector3);
		}
	}
}
