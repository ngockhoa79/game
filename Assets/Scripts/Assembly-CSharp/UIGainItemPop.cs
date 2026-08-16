using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGainItemPop : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CAsycCloseClicked_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGainItemPop _003C_003E4__this;

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
		public _003CAsycCloseClicked_003Ed__19(int _003C_003E1__state)
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

	[SerializeField]
	private UICmItemIcon ItemIcon;

	[SerializeField]
	private ThingIconNumFrame ThingIcon;

	[SerializeField]
	private UILabel LblItemName;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private List<GameObject> PanelList;

	[SerializeField]
	private UILabel LblItemDesc;

	[SerializeField]
	private UILabel LblSkillDesc;

	[SerializeField]
	private UILabel LblGearDesc;

	[SerializeField]
	private UILabel LblSignNumber;

	[SerializeField]
	private UICmStarDisplayer Stars;

	[SerializeField]
	private UICmStarDisplayer HeroStars;

	[SerializeField]
	private UISprite Sign;

	[SerializeField]
	private UISprite SignName;

	public Action closeCallback;

	public void SetData(SimpleItem item)
	{
	}

	protected override void DoClearData()
	{
	}

	public void OnActiveClick()
	{
	}

	private void OnCloseClicked(GameObject obj)
	{
	}

	private void OnCloseCallback()
	{
	}

	[IteratorStateMachine(typeof(_003CAsycCloseClicked_003Ed__19))]
	private IEnumerator AsycCloseClicked()
	{
		return null;
	}
}
