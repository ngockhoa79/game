using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/Demo/tk2dDemoAnimController")]
public class tk2dDemoAnimController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPopupText_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dDemoAnimController _003C_003E4__this;

		public string text;

		private float _003CfadeTime_003E5__2;

		private Color _003Cc1_003E5__3;

		private Color _003Cc2_003E5__4;

		private float _003Cf_003E5__5;

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
		public _003CPopupText_003Ed__4(int _003C_003E1__state)
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

	private tk2dSpriteAnimator animator;

	public tk2dTextMesh popupTextMesh;

	private void Start()
	{
	}

	private void AnimationEventHandler(tk2dSpriteAnimator animator, tk2dSpriteAnimationClip clip, int frameNum)
	{
	}

	[IteratorStateMachine(typeof(_003CPopupText_003Ed__4))]
	private IEnumerator PopupText(string text)
	{
		return null;
	}

	private void OnGUI()
	{
	}
}
