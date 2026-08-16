using System;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildSkillItem : IceUIBase
{
	public enum EState
	{
		AllLeaned = 0,
		Learning = 1,
		CannotLearn = 2
	}

	[SerializeField]
	private UILabel lbLevel;

	[SerializeField]
	private GameObject DisablePanel;

	[SerializeField]
	private Transform[] SkillIconSlots;

	[SerializeField]
	private IceAnimatorTotalCommander anim_enter;

	protected override void DoInit()
	{
	}

	public void Clear()
	{
	}

	public void SetData(int level, EState state, List<PlayerGuildInfoProto.BuffProto> list = null, Action<GuildActiveBuffTemplate> onOK = null)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}
}
