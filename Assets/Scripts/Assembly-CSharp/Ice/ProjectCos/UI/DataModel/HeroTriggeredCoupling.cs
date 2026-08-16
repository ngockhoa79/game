using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.DataModel
{
	public class HeroTriggeredCoupling : AbstractCoupling
	{
		[CompilerGenerated]
		private sealed class _003Cget_FerrserCards_003Ed__8 : IEnumerable<Hero>, IEnumerable, IEnumerator<Hero>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Hero _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public HeroTriggeredCoupling _003C_003E4__this;

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
			public _003Cget_FerrserCards_003Ed__8(int _003C_003E1__state)
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

		public static bool IsInFerrer;

		private int Findex;

		public FixedList<int> TriggerHeroGroupIDs { get; private set; }

		public IEnumerable<Hero> FerrserCards
		{
			[IteratorStateMachine(typeof(_003Cget_FerrserCards_003Ed__8))]
			get
			{
				return null;
			}
		}

		public override bool IsTriggered(Hero hero)
		{
			return false;
		}

		protected override bool FromTemplate(BondTemplateExt template)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
