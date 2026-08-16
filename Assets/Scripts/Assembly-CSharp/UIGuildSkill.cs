using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildSkill : IceUIBase
{
	public class GuildSkillVisualizer : IceUIReusableList<GuildSkillData>.IVisualizer
	{
		public Action<GuildActiveBuffTemplate> OnOK;

		public GuildSkillVisualizer(Action<GuildActiveBuffTemplate> onOK)
		{
		}

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, GuildSkillData data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIGuildSkillList List;

	[SerializeField]
	private UILabel GuildLevel;

	[SerializeField]
	private UILabel GuildBuffHealth;

	[SerializeField]
	private UILabel GuildBuffAttack;

	[SerializeField]
	private UILabel GuildBuffDefence;

	[SerializeField]
	private UILabel GuildBuffSpirit;

	[SerializeField]
	private UILabel Tip;

	[SerializeField]
	private UILabel GoldLabel;

	[SerializeField]
	private UILabel GuildCurrencyLable;

	[SerializeField]
	private UIEventListener HelpBtn;

	private float health;

	private float attack;

	private float defence;

	private float spirit;

	protected override void DoInit()
	{
	}

	private void handleOnOK(GuildActiveBuffTemplate t)
	{
	}

	protected override void DoPrepare()
	{
	}

	private void handleShowHelp(GameObject btn)
	{
	}

	protected override void DoDispose()
	{
	}

	public void Set()
	{
	}

	private void setTopCurrencyInfo()
	{
	}

	private void calculatePercentages()
	{
	}

	private void calculate(GuildActiveBuffTemplate.Bonuses[] bonus, int level)
	{
	}

	public void SetData(PlayerGuildInfoProto proto, bool refreshData)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}
}
