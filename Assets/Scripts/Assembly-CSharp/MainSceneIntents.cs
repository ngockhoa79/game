using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.Intents;

public class MainSceneIntents : IceUIIntent
{
	[CompilerGenerated]
	private sealed class _003C_wait_and_show__003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainSceneIntents _003C_003E4__this;

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
		public _003C_wait_and_show__003Ed__6(int _003C_003E1__state)
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

	private const string IntentKeyword = "MainScene";

	protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
	{
		return null;
	}

	protected override void SetPanelData()
	{
	}

	protected override void ClearPanelData()
	{
	}

	protected override void OnGetToForground()
	{
	}

	[IteratorStateMachine(typeof(_003C_wait_and_show__003Ed__6))]
	private IEnumerator _wait_and_show_()
	{
		return null;
	}

	protected override void OnGetToBackgorund()
	{
	}

	public static UIMainStage GetMainStage()
	{
		return null;
	}

	public static UIMainHeroGroupCtrller GetHeroGroupCtrller()
	{
		return null;
	}

	public static void ShowMainSceneCamera(bool bShow)
	{
	}

	private List<MainSceneManager.ButtonType> constructHideButtonsList()
	{
		return null;
	}

	private int getMaxLevelTemplate(IEnumerable<UiControlTemplate> found)
	{
		return 0;
	}

	private bool ProcessAutoIntent()
	{
		return false;
	}
}
