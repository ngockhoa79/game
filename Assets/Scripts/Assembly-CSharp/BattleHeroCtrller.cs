using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HutongGames.PlayMaker;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Spine;
using Spine36;
using Spine36.Unity;
using SpineWWW;
using SpineWWW.Unity;
using UnityEngine;

public class BattleHeroCtrller : MonoBehaviour
{
	public delegate void SpineAnimationEndEvent();

	public int FighterId;

	public int HeroId;

	public BattleHeroInfo heroInfo;

	public List<AbstractItem> Loots;

	public HeroFightType fightType;

	private bool isBoss;

	private float height;

	private string[] heroNames;

	private GameObject shadow;

	private GameObject spineObject;

	private Transform boneEffectRoot;

	private PlayMakerFSM heroFsm;

	private FsmState idleState;

	private SpineAnimationName anim_idleA;

	private SpineAnimationName anim_idleB;

	private UIBtFighterAttachments Attachment;

	private float hpBarTimer;

	private bool hpBarShowing;

	private Spine.Skeleton heroSkeleton;

	private SpineWWW.Skeleton heroSkeletonNew;

	private Spine36.Skeleton heroSkeleton36;

	private bool heroEffect;

	private bool initSkeletonOver;

	private GameObject runEffectObject;

	private Dictionary<HeroBoneEffectItem, GameObject> boneEffectsDic;

	private Vector3 normalScale;

	private Vector3 bossScale;

	private float fsmWaitTimer;

	private bool waitingForSendFsmEvent;

	private string fsmEvent;

	private float fsmDelayTime;

	private bool isBlowup => false;

	public bool IsLeftSide => false;

	public event SpineAnimationEndEvent onAnimComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void InitChildren()
	{
	}

	private void InitSkeletonData()
	{
	}

	public void UpdateSkeletonColor(Color _color)
	{
	}

	public void UpdateSkeletonColor(float _val)
	{
	}

	public void SetAlpha(float _alpha)
	{
	}

	private void LateUpdate()
	{
	}

	public void SetHeroIdByPrefabName(string _prefab, bool _isLeft, int _line, int _column)
	{
	}

	public void SetHeroInfo(ReportHeroInfo _info)
	{
	}

	public void SetHeroBossType(bool _isBoss)
	{
	}

	private void CheckScaleCorrect()
	{
	}

	public void BlowUpLikeBKB()
	{
	}

	public void FinishBlowUp()
	{
	}

	public void PlayCommonEffect(HeroCommonEffectType _type, bool _bind = true)
	{
	}

	public SkeletonAnimation GetSpineAnimation()
	{
		return null;
	}

	public SpineWWW.Unity.SkeletonAnimation GetSpineAnimationNew()
	{
		return null;
	}

	public Spine36.Unity.SkeletonAnimation GetSpineAnimation36()
	{
		return null;
	}

	public Spine.Skeleton GetSpineSkeleton()
	{
		return null;
	}

	public void RegisterToBattleManager(HeroFightType _type)
	{
	}

	public void SetLoots(AbstractItem _item)
	{
	}

	public void FsmEvent(string _fsmEvent, float _delay)
	{
	}

	public void CheckHeroEffects()
	{
	}

	public void ShowHpBar()
	{
	}

	public void ShowHeroHurtRed()
	{
	}

	public void SetHeight(float _height)
	{
	}

	public float GetHeight()
	{
		return 0f;
	}

	public void SetAttachment(UIBtFighterAttachments _attachment)
	{
	}

	public void DestroyAttachments()
	{
	}

	public void ShowCombo()
	{
	}

	public void ShowKezhiText(HarmInfoProto.AgainstType _type)
	{
	}

	public void ShowHarmInfo(HarmInfoProto _info, int _targetShowValue)
	{
	}

	public void ShowHarm(int _value)
	{
	}

	public void ShowHeal(int _value)
	{
	}

	public void StartDuel(int _spiritChange, int _hpChange, UIBtDuelPadCtrller.DuelOverEvent _event)
	{
	}

	public void SetHpFull()
	{
	}

	public int GetHeroHp()
	{
		return 0;
	}

	public void HideAttachment()
	{
	}

	public void ShowNamePad(bool _show)
	{
	}

	public void SpeakWin()
	{
	}

	public void Speak(BattleEmoteType _type)
	{
	}

	public void Speak(string _text)
	{
	}

	public void DealAnimationEnd()
	{
	}

	private void OnDestroy()
	{
	}
}
