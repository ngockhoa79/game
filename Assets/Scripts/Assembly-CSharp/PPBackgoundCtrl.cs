using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using UnityEngine;

public class PPBackgoundCtrl : IceUIBase
{
	public enum SubordinateType
	{
		None = 0,
		WorldBoss = 1,
		TrailTrav = 2,
		FragmentRob = 3,
		PVP = 4,
		PVE = 5,
		Makyou = 6
	}

	private SubordinateType subordinateType;

	public IceAnimatorTotalCommander play_point_in;

	public IceAnimatorTotalCommander play_point_out;

	public IceAnimatorTotalCommander button_in;

	public IceAnimatorTotalCommander quick_fadeout;

	public GameObject root;

	public UIEventListener btnBack;

	public UIEventListener btnPve;

	public UIEventListener btnPVP;

	public UIEventListener btnWorldBoss;

	public UIEventListener btnTrialTrav;

	public UIEventListener btnFragmentRob;

	public UIEventListener btnMakyou;

	public UISprite btnMakyouRoot;

	public UISprite btnMakyouBg;

	public UISprite spPVP;

	public UISprite spWorldBoss;

	public UISprite spTraialTrav;

	public UISprite spFragmentRob;

	[SerializeField]
	private UILabel lbTrialTime;

	[SerializeField]
	private UILabel lbConvoyTime;

	public Action E_OnPVE;

	public Action E_OnPVP;

	public Action E_OnWorldBoss;

	public Action E_OnTrialTrav;

	public Action E_OnFragmentRob;

	public Action E_OnMakyou;

	public Action<bool, SubordinateType> E_OnLeave;

	public UINotifyRedDot rdPVE;

	public UINotifyRedDot rdSkillRob;

	private bool _bLeaveToMainScene;

	private bool _play_in_finished;

	private bool isConvoyOpened;

	private float timeStayed;

	private bool makyouCloseOnEnter;

	private static int sCachedPlayerLevel;

	private static List<int> sCachedFeatureList;

	public void Update()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void SetTime()
	{
	}

	private void SetData()
	{
	}

	private void StopAllAnimation()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnPVEClick(GameObject go)
	{
	}

	private void OnPVPClick(GameObject btn)
	{
	}

	private void OnMakyouClick(GameObject btn)
	{
	}

	private void MakYouAction()
	{
	}

	public void LeaveScene(bool bLeaveToMainScene, SubordinateType t)
	{
	}

	protected override void DoDispose()
	{
	}

	public static bool IsFeatureActive(FunctionType type)
	{
		return false;
	}

	private void ActiveConvoyButton()
	{
	}

	private void ReloadActiveFunction()
	{
	}
}
