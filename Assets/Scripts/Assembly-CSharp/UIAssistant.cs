using UnityEngine;

public class UIAssistant : MonoBehaviour
{
	public enum ShortCuts
	{
		None = 0,
		Troops = 1,
		CardBag = 2,
		Gears = 3,
		Skills = 4,
		Tasks = 5
	}

	private static UIAssistant self;

	private const string TitleDown = "UIAssistantBtnTitleDown";

	private const string TitleUp = "UIAssistantBtnTitleUp";

	public UIEventListener TroopsBtn;

	public UIEventListener CardBagBtn;

	public UIEventListener GearsBtn;

	public UIEventListener SkillsBtn;

	public UIEventListener TasksBtn;

	public UIEventListener TitleBtn;

	public UISprite Title;

	public IceAnimatorTotalCommander Expand;

	public IceAnimatorTotalCommander Fold;

	private bool isFolded;

	private ShortCuts sc;

	public static UIAssistant Instance => null;

	public bool EnforceOn
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void attachEvents()
	{
	}

	private void handleTitleClicked(GameObject btn)
	{
	}

	private void playFoldAnimation()
	{
	}

	private void playUnFoldAnimation()
	{
	}

	private void handleTroopsClicked(GameObject btn)
	{
	}

	private void handleCardBagClicked(GameObject btn)
	{
	}

	private void handleGearsClicked(GameObject btn)
	{
	}

	private void handleSkillsClicked(GameObject btn)
	{
	}

	private void handleTasksClicked(GameObject btn)
	{
	}
}
