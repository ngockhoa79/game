using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine36.Unity.Modules
{
	public class SkeletonGhostRenderer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFade_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonGhostRenderer _003C_003E4__this;

			private int _003Ct_003E5__2;

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
			public _003CFade_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CFadeAdditive_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkeletonGhostRenderer _003C_003E4__this;

			private Color32 _003Cblack_003E5__2;

			private int _003Ct_003E5__3;

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
			public _003CFadeAdditive_003Ed__8(int _003C_003E1__state)
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

		public float fadeSpeed;

		private Color32[] colors;

		private Color32 black;

		private MeshFilter meshFilter;

		private MeshRenderer meshRenderer;

		private void Awake()
		{
		}

		public void Initialize(Mesh mesh, Material[] materials, Color32 color, bool additive, float speed, int sortingLayerID, int sortingOrder)
		{
		}

		[IteratorStateMachine(typeof(_003CFade_003Ed__7))]
		private IEnumerator Fade()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFadeAdditive_003Ed__8))]
		private IEnumerator FadeAdditive()
		{
			return null;
		}

		public void Cleanup()
		{
		}
	}
}
