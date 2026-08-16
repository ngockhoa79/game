using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UISJMapStageDisplayer : IceUIBase
{
	[Serializable]
	public enum Condition
	{
		Disabled = 0,
		Activety = 1,
		Bonusable = 2,
		Cleared = 3
	}

	public IceAnimatorTotalCommander animDisable;

	public IceAnimatorTotalCommander animActive;

	public IceAnimatorTotalCommander animBonus;

	public IceAnimatorTotalCommander animClear;

	public UIEventListener btnClicker;

	public Action<int> OnKick;

	public Action<int> OnObtain;

	public UILabel LblPlayerName;

	public UILabel LblGuildName;

	public UITexture ImgIcon;

	public UISprite spFrame;

	public VIPLabel VipLabel;

	public int Index;

	protected bool isSuperStage;

	protected const string Res = "icon_heroes";

	[SerializeField]
	private Condition _status;

	public UISJMapStageDisplayer[] nextStages;

	private UIDragObject StageDrager;

	public Condition Status
	{
		get
		{
			return default(Condition);
		}
		set
		{
		}
	}

	public virtual void SetData(HeroConfig card, string name, string guildName, int viplevel, Condition status = Condition.Disabled, bool playEffects = false)
	{
	}

	public void PlayClear()
	{
	}

	public void PlaySetIconFalse()
	{
	}

	public void SetStatus(Condition status, bool playEffects = false, Action callback = null)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}
}
