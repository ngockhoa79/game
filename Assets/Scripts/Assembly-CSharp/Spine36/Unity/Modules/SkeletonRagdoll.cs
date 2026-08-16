using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine36.Unity.Modules
{
	[RequireComponent(typeof(SkeletonRenderer))]
	public class SkeletonRagdoll : MonoBehaviour
	{
		public class LayerFieldAttribute : PropertyAttribute
		{
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonRagdoll _003C_003E4__this;

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
			public _003CStart_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CSmoothMixCoroutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonRagdoll _003C_003E4__this;

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
			public _003CSmoothMixCoroutine_003Ed__40(int _003C_003E1__state)
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

		[Space(18f)]
		[Tooltip("Set RootRigidbody IsKinematic to true when Apply is called.")]
		public bool pinStartBone;

		[Tooltip("Enable Collision between adjacent ragdoll elements (IE: Neck and Head)")]
		public bool enableJointCollision;

		public bool useGravity;

		[Tooltip("If no BoundingBox Attachment is attached to a bone, this becomes the default Width or Radius of a Bone's ragdoll Rigidbody")]
		public float thickness;

		[Tooltip("Default rotational limit value.  Min is negative this value, Max is this value.")]
		public float rotationLimit;

		public float rootMass;

		[Tooltip("If your ragdoll seems unstable or uneffected by limits, try lowering this value.")]
		[Range(0.01f, 1f)]
		public float massFalloffFactor;

		[Tooltip("The layer assigned to all of the rigidbody parts.")]
		public int colliderLayer;

		[Range(0f, 1f)]
		public float mix;

		private ISkeletonAnimation targetSkeletonComponent;

		private Skeleton skeleton;

		private Dictionary<Bone, Transform> boneTable;

		private Transform ragdollRoot;

		private Vector3 rootOffset;

		private bool isActive;

		public Rigidbody RootRigidbody { get; private set; }

		public Bone StartingBone { get; private set; }

		public Vector3 RootOffset => default(Vector3);

		public bool IsActive => false;

		public Rigidbody[] RigidbodyArray => null;

		public Vector3 EstimatedSkeletonPosition => default(Vector3);

		[IteratorStateMachine(typeof(_003CStart_003Ed__33))]
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

		[IteratorStateMachine(typeof(_003CSmoothMixCoroutine_003Ed__40))]
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

		public Rigidbody GetRigidbody(string boneName)
		{
			return null;
		}

		private void RecursivelyCreateBoneProxies(Bone b)
		{
		}

		private void UpdateSpineSkeleton(ISkeletonAnimation skeletonRenderer)
		{
		}

		private List<Collider> AttachBoundingBoxRagdollColliders(Bone b)
		{
			return null;
		}

		private static float GetPropagatedRotation(Bone b)
		{
			return 0f;
		}
	}
}
