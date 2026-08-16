using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/Deprecated/GUI/tk2dButton")]
public class tk2dButton : MonoBehaviour
{
	public delegate void ButtonHandlerDelegate(tk2dButton source);

	[CompilerGenerated]
	private sealed class _003CcoScale_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector3 defaultScale;

		public tk2dButton _003C_003E4__this;

		public float startScale;

		public float endScale;

		private float _003Ct0_003E5__2;

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
		public _003CcoScale_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CLocalWaitForSeconds_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		private float _003Ct0_003E5__2;

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
		public _003CLocalWaitForSeconds_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CcoHandleButtonPress_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dButton _003C_003E4__this;

		public int fingerId;

		private bool _003CbuttonPressed_003E5__2;

		private Vector3 _003CdefaultScale_003E5__3;

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
		public _003CcoHandleButtonPress_003Ed__36(int _003C_003E1__state)
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

	public Camera viewCamera;

	public string buttonDownSprite;

	public string buttonUpSprite;

	public string buttonPressedSprite;

	private int buttonDownSpriteId;

	private int buttonUpSpriteId;

	private int buttonPressedSpriteId;

	public AudioClip buttonDownSound;

	public AudioClip buttonUpSound;

	public AudioClip buttonPressedSound;

	public GameObject targetObject;

	public string messageName;

	private tk2dBaseSprite sprite;

	private bool buttonDown;

	public float targetScale;

	public float scaleTime;

	public float pressedWaitTime;

	public event ButtonHandlerDelegate ButtonPressedEvent
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

	public event ButtonHandlerDelegate ButtonAutoFireEvent
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

	public event ButtonHandlerDelegate ButtonDownEvent
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

	public event ButtonHandlerDelegate ButtonUpEvent
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

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void UpdateSpriteIds()
	{
	}

	private void PlaySound(AudioClip source)
	{
	}

	[IteratorStateMachine(typeof(_003CcoScale_003Ed__34))]
	private IEnumerator coScale(Vector3 defaultScale, float startScale, float endScale)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLocalWaitForSeconds_003Ed__35))]
	private IEnumerator LocalWaitForSeconds(float seconds)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoHandleButtonPress_003Ed__36))]
	private IEnumerator coHandleButtonPress(int fingerId)
	{
		return null;
	}

	private void Update()
	{
	}
}
