using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class MeDisplayer : PlayerDisplayer
{
	private const string ResCategory = "uiarena";

	private const string PrefabConfirmDelivery = "ArenaPopUpConfirmDelivery";

	private const string PrefabExtraRedpack = "ArenaPopUpExtraRedPack";

	private PVPPlayer mePlayer;

	[SerializeField]
	private UILabel nextRefreshTime;

	private TimeSpan interval;

	[SerializeField]
	private UILabel RankingText;

	public UILabel NextReputation;

	private static MeDisplayer self;

	private UIHeroLoader uiHeroLoader;

	public static MeDisplayer Self => null;

	public override PVPPlayer Player
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void showTimeCycleDetail()
	{
	}

	protected override void DoDispose()
	{
	}

	private void loadSpineUgly(Shader topShader)
	{
	}

	private void createOrSteal()
	{
	}

	private void fixSpine(GameObject spine)
	{
	}

	public void RefreshReputation(int delta)
	{
	}
}
