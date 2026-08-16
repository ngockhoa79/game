using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class CollectionSkillPanel : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CclearUnuseRes_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectionSkillPanel _003C_003E4__this;

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
		public _003CclearUnuseRes_003Ed__17(int _003C_003E1__state)
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

	public UIScrollView sv;

	public UICenterOnChild CenterChild;

	public UIGrid gdPages;

	private bool mIsNeedCleanRes;

	private int mCurPage;

	private bool mIsMoveForward;

	private List<ItemCollectionPageSkill> mPages;

	private UIItemPool<ItemCollectionSkill> mUIPool;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void LoadPageInfo(int pageIndex)
	{
	}

	public void UnLoadPageInfo(int pageIndex)
	{
	}

	public void CreateAllPage()
	{
	}

	[IteratorStateMachine(typeof(_003CclearUnuseRes_003Ed__17))]
	private IEnumerator clearUnuseRes()
	{
		return null;
	}

	private void loadPageTexture(int index)
	{
	}

	private void unloadPageTexture(int index)
	{
	}

	public ItemCollectionSkill OnCreateUIItem()
	{
		return null;
	}
}
