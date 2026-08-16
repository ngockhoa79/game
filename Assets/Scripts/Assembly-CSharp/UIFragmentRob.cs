using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

public class UIFragmentRob : IceUIBase
{
	public static bool ForceShowSpine;

	public UIFragmentRobTarget[] targets;

	public UIEventListener btnHomePage;

	public UIEventListener btnReturn;

	public UIEventListener btnRefresh;

	public UIButton buttonRefresh;

	public UIMainScenePlayerInfo playerInfo;

	public UIFragmentCombineTop fragmentTop;

	public Action E_OnBack;

	public Action E_OnHomePage;

	public Action E_OnRefreshOpponents;

	public Action<S2CRobberyOpponentsAck.TargetInfoProto> E_OnSelectTarget;

	private SkillFragment _dataFragment;

	private S2CRobberyOpponentsAck.TargetInfoProto[] _dataPlayerSnapshots;

	public void SetData(SkillFragment skillFragment, S2CRobberyOpponentsAck.TargetInfoProto[] snapShots)
	{
	}

	public void Refresh(SkillFragment skillFragment, S2CRobberyOpponentsAck.TargetInfoProto[] snapShots)
	{
	}

	public void ShowCharacters(bool bShow)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void show_skill_fragment_info()
	{
	}

	private void show_target_list()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}
}
