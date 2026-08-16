using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVERoot : IceUIBase
{
	private enum AreaSwitchStep
	{
		None = 0,
		MovingMap = 1,
		OpenFog = 2,
		End = 3,
		_NUM = 4
	}

	private enum PVEUIStatus
	{
		None = 0,
		DuplicationSwitch = 1,
		AreaSwitch = 2,
		_NUM = 3
	}

	[CompilerGenerated]
	private sealed class _003CStartChangeDifficultyTo_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVERoot _003C_003E4__this;

		public PVEProgress.PVEType pveType;

		public Action callback;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartChangeDifficultyTo_003Ed__73(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAsycMoveMapToNewArea_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVERoot _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAsycMoveMapToNewArea_003Ed__89(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAsycUnlockNewDuplication_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVERoot _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAsycUnlockNewDuplication_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Action E_OnClose;

	public Action E_OnReturn;

	public Action<int> E_OnSelectChapter;

	public UIPVEDuplication pveDuplication;

	public TweenPosition pveDuplicationMovement;

	public UIEventListener btnClose;

	public UIEventListener btnReturn;

	public UIEventListener btnChangeDifficulty;

	public GameObject BtnText_HeroLevel;

	public GameObject BtnText_NormalLevel;

	public UINotifyRedDot rdNormalInNormalLevel;

	public UINotifyRedDot rdHeroInNormalLevel;

	public UINotifyRedDot rdNormalInHeroLevel;

	public UINotifyRedDot rdHeroInHeroLevel;

	public GameObject goAirPlane;

	public TweenPosition goAirPlaneMovement;

	public IceAnimatorTotalCommander airPlaneMove2LandAni;

	public IceAnimatorTotalCommander airPlaneLand2MoveAni;

	public IceAnimatorTotalCommander levelNormalAni;

	public IceAnimatorTotalCommander levelHeroAni;

	public UIDragObject DragBackground;

	public IceAnimatorTotalCommander[] NormalAreaOpenAni;

	public IceAnimatorTotalCommander[] EliteAreaOpenAni;

	public GameObject NormalMapPath;

	public GameObject EliteMapPath;

	public UILabel ChapterName;

	public UILabel AreaName;

	public IceAnimatorTotalCommander ChapterChangeAni;

	public IceAnimatorTotalCommander AreaOpenAni;

	public UITexture[] PopupChapterSlotTex;

	public TweenPosition[] PopupChapterMovement;

	public UISprite DragContent;

	public List<Transform> SlotTr;

	[SerializeField]
	private UINotificationAttacher notificationAttacher;

	private UIPVESubDuplication preOpenDuplication;

	private UIPVESubDuplication currentOpenDuplication;

	private int preOpenArea;

	private int currentAreaChapterCount;

	private int totalChapterCount;

	private List<UIPVESubDuplication> PVEDupList;

	private bool bAnimating;

	private bool isAirplaneLanding;

	private float preFogPositionX;

	private float fogOffsetX;

	private float areaSide;

	private GameObject EliteOpenObj;

	private UIPVEEliteOpen EliteOpen;

	private int preDuplicationId;

	private int focusNormalDuplicationId;

	private int focusHeroDuplicationId;

	private readonly float FOG_INTERVAL_X;

	private readonly float FOG_SIDE_X;

	private readonly float SWITCH_WAIT_TIMES;

	public static float[] AREA_SIDE;

	private readonly int[] AREA_CHAPTERS;

	private readonly string imagePerfix;

	private bool bPlaySwitchDuplication;

	private AreaSwitchStep CurrentAreaSwitchStep;

	private int CurrentUIStatus;

	private void CurrentUIStatusSwitch(bool bSwitchStatus = true)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void Update()
	{
	}

	private void SpawnDuplications()
	{
	}

	private void PopupEliteOpen()
	{
	}

	private void SpawnSimpleDuplication(int chapterId, Transform parentTr)
	{
	}

	public void OnSwitchStatus()
	{
	}

	public void SetToBackground(bool bBackground)
	{
	}

	private void SetLevel(PVEProgress.PVEType pveType)
	{
	}

	private void SetLevelCallback()
	{
	}

	[IteratorStateMachine(typeof(_003CStartChangeDifficultyTo_003Ed__73))]
	private IEnumerator StartChangeDifficultyTo(PVEProgress.PVEType pveType, Action callback)
	{
		return null;
	}

	private void SetLevelInternal(PVEProgress.PVEType pveType)
	{
	}

	private UIPVESubDuplication GetDuplication(int duplicationId)
	{
		return null;
	}

	private void RefreshAirPlanePosition()
	{
	}

	private Vector3 AirPlanePosition(int duplicationID)
	{
		return default(Vector3);
	}

	private void SetAirplanePosition(int duplicationID)
	{
	}

	private void InitSwitchStatus(bool isPrepare)
	{
	}

	private void SetMapPosition()
	{
	}

	private void SetMapCurOpenPosition()
	{
	}

	private void SetMapToDefaultPosition()
	{
	}

	private void CloseEliteOpen()
	{
	}

	private bool LevelCheck()
	{
		return false;
	}

	private void OnSwitchDifficulty(GameObject go)
	{
	}

	private void OnCloseClicked(GameObject go)
	{
	}

	private void OnSelectChapter(int chapterId)
	{
	}

	private void MoveMapToNewArea()
	{
	}

	[IteratorStateMachine(typeof(_003CAsycMoveMapToNewArea_003Ed__89))]
	private IEnumerator AsycMoveMapToNewArea()
	{
		return null;
	}

	public void MoveMapOver()
	{
	}

	private void AirplaneMove()
	{
	}

	public void OnAirplaneStop()
	{
	}

	private void UnlockNewDuplication()
	{
	}

	[IteratorStateMachine(typeof(_003CAsycUnlockNewDuplication_003Ed__94))]
	private IEnumerator AsycUnlockNewDuplication()
	{
		return null;
	}

	private void UpdateSwitchStatus()
	{
	}

	private void InitFogPosition(int areaID)
	{
	}

	private void UpdateFogPosition()
	{
	}

	private void OnCloseLoading()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}
}
