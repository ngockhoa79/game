using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class UIMainStage : MonoBehaviour
{
	private enum EPanels
	{
		NoPanel = 0,
		MainScene = 1,
		Arena = 2,
		ArrayEditor = 3,
		Luggage = 4,
		Friend = 5,
		PlayPoint = 6,
		PVE = 7,
		DrawCard = 8
	}

	public UIMainHeroGroupCtrller uiMainHeroGroupCtrller;

	public GameObject SceneCamera;

	public const int SUB_PANEL_DEPTH_DELTA = 10;

	private EPanels activePanel;

	public void ShowMainScene(bool bShow)
	{
		UnityEngine.Debug.Log($"[STAGE2] UIMainStage.ShowMainScene(bShow={bShow}) called");
		if (SceneCamera != null)
		{
			SceneCamera.SetActive(bShow);
		}
	}

	private void destroyActivePanel(EPanels targetPanel)
	{
		switch (targetPanel)
		{
			case EPanels.MainScene:
				ShowMainScene(false);
				break;
		}
	}

	private bool activatePanel(EPanels panel)
	{
		if (activePanel == panel) return false;
		destroyActivePanel(activePanel);
		activePanel = panel;
		switch (activePanel)
		{
			case EPanels.MainScene:
				ShowMainScene(true);
				break;
		}
		return true;
	}

	private void Awake()
	{
		UnityEngine.Debug.Log("[STAGE2-AUDIT] UIMainStage.Awake() executing");
	}

	private void OnEnable()
	{
		UnityEngine.Debug.Log("[STAGE2-AUDIT] UIMainStage.OnEnable() executing");
	}

	private void Start()
	{
		UnityEngine.Debug.Log("[STAGE2] UIMainStage.Start() executing after Stage2_Main loaded");
		if (GlobalManager.Instance != null)
		{
			UnityEngine.Debug.Log("[STAGE2] Calling GlobalManager.Instance.UserLogin()");
			GlobalManager.Instance.UserLogin();
		}
		UnityEngine.Debug.Log("[STAGE2] Calling activateMainScene()");
		activateMainScene();
	}

	public void DestroyMainStage()
	{
	}

	public void ExitScene()
	{
	}

	public void activateArena()
	{
		new CouponIntents().Perform(null, true, true, false, true);
	}

	private void destroyArena()
	{
	}

	public void activateArrayEditor()
	{
		new ArrayEditorIntent().Perform(null, true, true, false, true);
	}

	private void destroyArrayEditor()
	{
	}

	public void activateCardBag()
	{
		new CouponIntents().Perform(null, true, true, false, true);
	}

	public void activateCardEnchance()
	{
		new CardStrengthenIntent().Perform(null, true, true, false, true);
	}

	public void activateDrawCard()
	{
		new Ice.ProjectCos.UI.Intents.DrawCardIntent(0).Perform(null, true, true, false, true);
	}

	public void activateFriend()
	{
		new FriendIntent().Perform(null, true, true, false, true);
	}

	public void activateGuild()
	{
	}

	public void activeShop()
	{
		new Ice.ProjectCos.UI.Intents.DrawCardIntent(0).Perform(null, true, true, false, true);
	}

	public void activateLuggage()
	{
		new LuggageIntents(LuggageIntents.ETab.All).Perform(null, true, true, false, true);
	}

	private void destroyLuggage()
	{
	}

	public void activeEquipEnchance()
	{
	}

	public void activateLianhua()
	{
	}

	public void activateSkillLuggage()
	{
		new LuggageIntents(LuggageIntents.ETab.Skill).Perform(null, true, true, false, true);
	}

	public void activateItemLuggage()
	{
		new LuggageIntents(LuggageIntents.ETab.Item).Perform(null, true, true, false, true);
	}

	public void activateGearLuggage()
	{
		new LuggageIntents(LuggageIntents.ETab.Gear).Perform(null, true, true, false, true);
	}

	public void activateSkillUpgrader()
	{
	}

	private void activateMainScene()
	{
		UnityEngine.Debug.Log("[STAGE2] UIMainStage.activateMainScene() executing");
		activePanel = EPanels.MainScene;
		if (uiMainHeroGroupCtrller != null)
		{
			UnityEngine.Debug.Log("[STAGE2] Showing team heroes via uiMainHeroGroupCtrller.ShowTeamHeros()");
			uiMainHeroGroupCtrller.ShowTeamHeros();
		}
		ShowMainScene(true);
	}

	private void destroyMainScene()
	{
	}

	public void activatePlayPoint()
	{
		activatePanel(EPanels.PlayPoint);
		UIPVEDuplication pveDup = GetComponentInChildren<UIPVEDuplication>(true);
		if (pveDup != null)
		{
			pveDup.gameObject.SetActive(true);
			pveDup.SetData(false);
		}
	}
}
