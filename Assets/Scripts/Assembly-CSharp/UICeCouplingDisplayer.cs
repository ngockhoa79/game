using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

public class UICeCouplingDisplayer : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003Cget_FerrserCards_003Ed__38 : IEnumerable<Hero>, IEnumerable, IEnumerator<Hero>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Hero _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UICeCouplingDisplayer _003C_003E4__this;

		Hero IEnumerator<Hero>.Current
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
		public _003Cget_FerrserCards_003Ed__38(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<Hero> IEnumerable<Hero>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[SerializeField]
	private Color nameActiveColor;

	[SerializeField]
	private Color nameInActiveColor;

	[SerializeField]
	private Color descActiveColor;

	[SerializeField]
	private Color descInActiveColor;

	[SerializeField]
	private UISprite bg;

	[SerializeField]
	private UISprite nameBG;

	[SerializeField]
	private new UILabel name;

	[SerializeField]
	private UILabel desc;

	private const string ActiveBG = "ArrayCouplingActive";

	private const string InActiveBG = "ArrayCouplingInActive";

	private const string ActiveNameSlot = "ArrayCouplingTitleActive";

	private const string InActiveNameSlot = "ArrayCouplingTitleInActive";

	[SerializeField]
	private UICeSlot leftTriple;

	[SerializeField]
	private UICeSlot rightTriple;

	[SerializeField]
	private UICeSlot oneSlot;

	[SerializeField]
	private UICmItemIcon equipmentThumb;

	[SerializeField]
	private UICmSkillIcon skillThumb;

	private BattleArray exhibitArray;

	private List<int> TribleFindindex;

	private int Findex;

	private bool IsFerrertriger;

	public AbstractCoupling Coupling { get; private set; }

	public IEnumerable<Hero> FerrserCards
	{
		[IteratorStateMachine(typeof(_003Cget_FerrserCards_003Ed__38))]
		get
		{
			return null;
		}
	}

	private void clear()
	{
	}

	public void Set(AbstractCoupling coupling, Hero card, BattleArray ary)
	{
	}

	private void set(AbstractCoupling coupling, Hero card)
	{
	}

	private void detailedDisplayer(AbstractCoupling coupling, Hero card)
	{
	}

	private void setupEquipment(GearTriggeredCoupling coupling, Hero card)
	{
	}

	private void setupSkill(SkillTriggeredCoupling coupling, Hero card)
	{
	}

	private void setupGroupTriple(HeroTriggeredCoupling coupling, HeroConfig left, HeroConfig right, Hero card)
	{
	}

	private float GetAverageLv(List<int> Lvlist)
	{
		return 0f;
	}

	private void setupGroupDouble(HeroTriggeredCoupling coupling, HeroConfig hc, Hero card)
	{
	}

	private bool isTriggered(FixedList<int> groups, Hero card)
	{
		return false;
	}

	private bool isTribleTriggered(FixedList<int> groups, Hero card)
	{
		return false;
	}

	private bool isFerrerTroubleTriggered(FixedList<int> groups, Hero card)
	{
		return false;
	}

	private bool isInArray(Hero hero)
	{
		return false;
	}

	private void setTriggered(bool isT)
	{
	}

	private void SetTrigerFerrer()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoClearData()
	{
	}

	private string toPercentage(float v)
	{
		return null;
	}
}
