using System.Collections.Generic;
using UnityEngine;

public class UIBtFighterAttachments : MonoBehaviour
{
	public enum ENamePadStyle
	{
		RedFighter = 0,
		BlueFighter = 1,
		GreenFighter = 2
	}

	private bool prepared;

	public GameObject Fighter;

	[HideInInspector]
	public bool IsAtLeftSide;

	public BattleChatBubble Bubble;

	[HideInInspector]
	public Vector3 BubbleLocalOffset;

	public readonly UIBtFighterInfo Info;

	[HideInInspector]
	public Vector3 NamePadLocalOffset;

	public const int NAME_PAD_STYLE_COUNT = 4;

	public GameObject NamePadRoot;

	private Dictionary<ENamePadStyle, FeaturedProgress> NamePadsDic;

	private ENamePadStyle namePadStyle;

	public UIBtDuelPadCtrller duelPad;

	[HideInInspector]
	public Vector3 WordsLocalOffset;

	public UIBtWordsPlayer WordsPlayer;

	private bool wordPosRan;

	private float wordTimer;

	private float wordCounter;

	private const int MAX_WORD_COUNTER = 3;

	public UIBtAttachSkillNameCtrller SkillNameCtrller;

	public ENamePadStyle NamePadStyle
	{
		get
		{
			return default(ENamePadStyle);
		}
		set
		{
		}
	}

	public FeaturedProgress ActiveNamePad => null;

	private void prepareWidgets()
	{
	}

	public void Attach(GameObject fighter, bool isAtLeftSide)
	{
	}

	public void Attach(GameObject fighter, bool isAtLeftSide, Vector3 namePadLocalOffset, Vector3 bubbleLocalOffset, Vector3 wordsLocalOffset)
	{
	}

	private void SetHeroInfo(GameObject fighterObject)
	{
	}

	public void Speak(BattleEmoteType _type)
	{
	}

	public void Speak(string _text)
	{
	}

	public void ShowNamePad(bool _show)
	{
	}

	public void StartDuel(int _spiritMax, int _spiritChange, int _hpChange, UIBtDuelPadCtrller.DuelOverEvent _event)
	{
	}

	public UIBtWordsAnimator PlayWords(string words, EDmgTextType type)
	{
		return null;
	}

	public void ShowSKillName(int _skillId, GameObject _nameObject)
	{
	}

	public void HideAll()
	{
	}

	public void SetHpFull()
	{
	}

	public float GetHpPercent()
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void updateNamePad()
	{
	}

	private void updatePos()
	{
	}

	public void DestoryAll()
	{
	}
}
