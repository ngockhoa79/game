using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu(null)]
public class tk2dUpdateManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CcoSuperLateUpdate_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUpdateManager _003C_003E4__this;

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
		public _003CcoSuperLateUpdate_003Ed__7(int _003C_003E1__state)
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

	private static tk2dUpdateManager inst;

	[SerializeField]
	private List<tk2dTextMesh> textMeshes;

	private static tk2dUpdateManager Instance => null;

	public static void QueueCommit(tk2dTextMesh textMesh)
	{
	}

	public static void FlushQueues()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CcoSuperLateUpdate_003Ed__7))]
	private IEnumerator coSuperLateUpdate()
	{
		return null;
	}

	private void QueueCommitInternal(tk2dTextMesh textMesh)
	{
	}

	private void FlushQueuesInternal()
	{
	}
}
