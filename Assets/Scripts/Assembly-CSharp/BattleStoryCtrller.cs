using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using UnityEngine;

public class BattleStoryCtrller : MonoBehaviour
{
	private enum StoryTeachState
	{
		Start = 0,
		T7S7Teached = 1,
		T7S8Teached = 2,
		T8S10Teached = 3
	}

	public UILabel textLabel;

	public UITexture leftPic;

	public UITexture rightPic;

	public UILabel leftName;

	public UILabel rightName;

	public GameObject leftRoot;

	public GameObject rightRoot;

	public GameObject leftNameRoot;

	public GameObject rightNameRoot;

	public Transform dialogBgTran;

	public GameObject nextButton;

	public Action storyOver;

	private List<StoryTemplateExt> stories;

	private int currentIndex;

	private float uiscale;

	private float shakeTimer;

	private bool shaking;

	private int leftHero;

	private int rightHero;

	private GameObject leftNpcEm;

	private GameObject rightNpcEm;

	private const float DIALOG_SHOW_SPEED = 20f;

	private GameObject storyRoot;

	private bool dialogShowing;

	private bool spinePlaying;

	private float dialogShowTimer;

	private string dialogText;

	private Color darkColor;

	private bool teaching;

	private const int Tutorial6 = 6;

	private const string T6State7 = "State 7";

	private const string T6State8 = "State 8";

	private const int Tutorial7 = 7;

	private const string T7State11 = "State 10";

	private StoryTeachState currentTeachState;

	public void StartPlayStory(int _pveId, Action _finishCallback, StoryTimingType _timing, int _rightColumn)
	{
	}

	public void StartPlayTeaching(BattleTeachType _type, Action _finishCallback)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void DialogShowOver()
	{
	}

	private void SetLeftHero(int _heroId)
	{
	}

	private void SetRightHero(int _heroId)
	{
	}

	private Texture GetCardTexture(int _heroId)
	{
		return null;
	}

	private void HandleNpcEm(int _heroId, bool _left)
	{
	}

	private void EnlightHero(bool _left)
	{
	}

	private void CheckNpcEm(bool _left, int _em)
	{
	}

	private void SetSpeakAside()
	{
	}

	private void HandleTeachStepOver()
	{
	}

	private void finishTechSteps()
	{
	}

	private void OnClick()
	{
	}

	private void PlayCurrentStory()
	{
	}

	private void InitDialogLabel()
	{
	}

	private void SpineOneStoryPlayOver()
	{
	}

	private int GetSpineHeroId(int _charId)
	{
		return 0;
	}
}
