using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIGuildSkillPopUp : IceUIBase
{
	private const string LevelTemplate = "[ffffff]Lv. [ffff00]{0}[ffffff]/{1}";

	[SerializeField]
	private UITexture Icon;

	[SerializeField]
	private UILabel Name;

	[SerializeField]
	private UILabel LevelIndicator;

	[SerializeField]
	private UILabel CurrentLevel;

	[SerializeField]
	private UILabel ToLevel;

	[SerializeField]
	private UISprite MaxLevel;

	[SerializeField]
	private UIGuildSkillPropertyGroup[] PropertyGroups;

	[SerializeField]
	private UILabel CostGuild;

	[SerializeField]
	private UILabel CostGold;

	[SerializeField]
	private UISprite CostGuildIcon;

	[SerializeField]
	private UISprite CostGoldIcon;

	[SerializeField]
	private UISprite CostIcon;

	[SerializeField]
	private UIEventListener CloseBtn;

	[SerializeField]
	private UIEventListener SmeltBtn;

	[SerializeField]
	private IceAnimatorTotalCommander Anim;

	private int guildCost;

	private int goldCost;

	private int curLevel;

	private int maxLevel;

	private UIGuildSkillItem.EState state;

	private int buffId;

	private GuildActiveBuffTemplate t;

	private GuildActiveBuffTextTemplate tt;

	public Action OnClose;

	public Action<GuildActiveBuffTemplate> OnOK;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
		if (CloseBtn != null)
		{
			CloseBtn.onClick = (btn) => { if (OnClose != null) OnClose(); gameObject.SetActive(false); };
		}
		if (SmeltBtn != null)
		{
			SmeltBtn.onClick = handleSmelt;
		}
	}

	protected override void DoDispose()
	{
	}

	public void SetData(int c, UIGuildSkillItem.EState state, GuildActiveBuffTemplate t, GuildActiveBuffTextTemplate tt)
	{
		this.curLevel = c;
		this.state = state;
		this.t = t;
		this.tt = tt;
		gameObject.SetActive(true);
		if (Name != null && tt != null) Name.text = tt.BuffName;
	}

	private void handleSmelt(GameObject btn)
	{
		if (OnOK != null && t != null)
		{
			OnOK(t);
		}
		gameObject.SetActive(false);
	}

	private void tip(string t)
	{
	}
}
