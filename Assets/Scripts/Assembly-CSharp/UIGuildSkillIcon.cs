using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIGuildSkillIcon : MonoBehaviour
{
	public Action<int, UIGuildSkillItem.EState, GuildActiveBuffTemplate, GuildActiveBuffTextTemplate> E_OnLearn;

	[SerializeField]
	private UILabel lbSkillName;

	[SerializeField]
	private UILabel lbCount;

	[SerializeField]
	private UITexture txIcon;

	[SerializeField]
	private GameObject spUpArrow;

	[SerializeField]
	private UIEventListener btnLearn;

	[SerializeField]
	private UISprite spMax;

	private int curLevel;

	private UIGuildSkillItem.EState state;

	private GuildActiveBuffTemplate template;

	private GuildActiveBuffTextTemplate textTemplate;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void clear()
	{
	}

	public void SetData(int guildBuffId, int curLevel, UIGuildSkillItem.EState state, bool bForceHideUpArrow = false)
	{
	}

	private void showBtnSprites(Transform btn, bool isMax)
	{
	}
}
