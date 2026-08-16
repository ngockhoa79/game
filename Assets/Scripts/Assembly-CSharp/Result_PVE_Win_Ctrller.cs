using UnityEngine;

public class Result_PVE_Win_Ctrller : MonoBehaviour
{
	public GameObject starGroup;

	public GameObject expModule;

	public GameObject moneyModule;

	public GameObject friendPointModule;

	public GameObject lootGroup;

	public GameObject replayBtn;

	public GameObject nextBtn;

	public GameObject titleAnim;

	public GameObject listAnim;

	public GameObject levelUpAnim;

	public GameObject buttonsAnim;

	public IceAnimatorTotalCommander totalAnim;

	private DuplicateSettlement settlement;

	private bool showOver;

	private float timer;

	private bool expStart;

	private bool moneyStart;

	private bool friendPointStart;

	private bool lootStart;

	private bool needLoot;

	private int moduleFinishCounter;

	private int allModuleNumber;

	private bool isActivity;

	private const float PVE_LOOT_Y = -75f;

	private const float ACTIVITY_LOOT_Y = -45f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void InitData()
	{
	}

	public void ShowResult(bool _isActivity)
	{
	}

	public void ShowImmediately()
	{
	}

	private void showGuidance()
	{
	}

	public void Click_Replay(GameObject _object)
	{
	}

	public void Click_Next(GameObject _object)
	{
	}

	private void modulePlayOver()
	{
	}

	private void PlayExp()
	{
	}

	private void ExpLevelup()
	{
	}

	private void PlayMoney()
	{
	}

	private void PlayFriendPoint()
	{
	}

	private void PlayItems()
	{
	}

	private void PlayButtons()
	{
	}

	private void buttonsPlayOver(IceAnimator _animator)
	{
	}

	private void CheckTeamLevelup()
	{
	}

	private void ShowThisWithObject(GameObject _object)
	{
	}
}
