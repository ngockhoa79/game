using UnityEngine;

public class Editor_BattleTestCtrller : MonoBehaviour
{
	public GameObject UIHeroSelectPanel;

	public GameObject UIFightPanel;

	public GameObject LoadingPanel;

	public GameObject HerosNode;

	public GameObject SkillsNode;

	public GameObject SkillUnblockNode;

	public GameObject BuffsNode;

	public GameObject EffectsNode;

	public GameObject BgNode;

	public UIBattle uiCtrller;

	public Editor_UIEditorCtrller editorUICtrller;

	public Camera BattleCam;

	public Camera UICam;

	public BattleBgEffectCtrller bgEffectCtrller;

	private GameObject leftHero;

	private GameObject leftPasser;

	private GameObject leftSupport;

	private GameObject rightHero;

	private GameObject rightPasser;

	private GameObject rightPasser2;

	private GameObject rightSupport;

	private string leftPrefab;

	private string rightPrefab;

	private bool skeletonLoadOver;

	public float gcTimer;

	public long lastMem;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartSkill(string _skillName, bool _isLeft)
	{
	}

	private void ClearWander(bool _isLeft)
	{
	}

	public void StartFight(string _leftName, string _rightName, string _bgName)
	{
	}

	private void CheckBattleScene(string _bgName)
	{
	}

	private void CreateHeros()
	{
	}

	public void ResetHeros()
	{
	}

	public void BackToHomepage()
	{
	}

	public void GotoSameline()
	{
	}

	private void ResetOneHero(GameObject _hero)
	{
	}

	private void ResetHeroLocalPostions()
	{
	}
}
