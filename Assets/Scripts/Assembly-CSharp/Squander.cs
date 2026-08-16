using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class Squander : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CwaitAndCommit_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Squander _003C_003E4__this;

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
		public _003CwaitAndCommit_003Ed__103(int _003C_003E1__state)
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

	private static Squander self;

	public const int MAX = 32;

	private const string UIAnchorTag = "SquanderGuidance";

	private const string UIPath = "UI/SquanderGuidance/";

	private const string ConditionalJudgment = "ConditionalJudgment";

	private const char Dash = '_';

	private const string Single = "single";

	private const string Multi = "multi";

	private const string STEP = "step";

	private const int Tutorial2 = 2;

	private const int Tutorial3 = 3;

	private const int Tutorial6 = 6;

	private const int Tutorial7 = 7;

	private const int Tutorial15 = 15;

	private const int Tutorial19 = 19;

	public bool IsTutorial6GotServerConfirm;

	public bool IsTutorial7GotServerConfirm;

	private Dictionary<int, bool> tutorialStatus;

	private bool isEnable;

	private static bool isUnderGuide;

	private static bool isUnderJudge;

	private static bool isDeferredJudge;

	private string stageID;

	private string step;

	private Stimulate stimulate;

	private BitArray progress;

	private PlayMakerFSM conditionalJudgment;

	private int lastUnFinishedIndex;

	private GameObject uiRoot;

	private bool isServerStorageGuideFinished;

	[HideInInspector]
	public bool RevokeToTargetFlag;

	public Action<string> OnNextStep;

	private Action onInterrupt;

	public Action OnOneTutorialFinished;

	public Action OnOneTutorialBegan;

	private bool skipSaver;

	private bool isTutorial26Meet;

	private BitArray JudgeDone;

	private List<int> exclusion;

	private static int preemCounter;

	public static Squander I => null;

	public bool IsUnderGuide => false;

	public bool IsUnderJudge => false;

	public bool IsTutorial6Started => false;

	public bool IsTutorial7Started => false;

	public bool IsTutorialAddAsFriendStarted => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void registerGenericEventHandler()
	{
	}

	private void fetchGameSettings()
	{
	}

	public void SetGuidance()
	{
	}

	public void SetProgressAfterLogin(int p, int data)
	{
	}

	public void UpdateProgressByIndex(int index)
	{
	}

	public void Launch(string id, bool squeeze = false)
	{
	}

	private void handleTutorialsBegan(string id)
	{
	}

	public void Interrupt(bool sendReq)
	{
	}

	public void SetDeferredJudge(bool v)
	{
	}

	public bool UnderGuide(int id)
	{
		return false;
	}

	public void StartJudge()
	{
	}

	public void StopJudge()
	{
	}

	public string GetStageID()
	{
		return null;
	}

	public bool IsLastTutorialInterrupted(out int index)
	{
		index = default(int);
		return false;
	}

	public bool IsStageFinished(int stage)
	{
		return false;
	}

	public bool Escapable()
	{
		return false;
	}

	public void LogOut()
	{
	}

	public void SetSkip()
	{
	}

	public bool GetSkip()
	{
		return false;
	}

	public void IsTutorial26Meet(List<ItemChangeProto> cards)
	{
	}

	private bool isPurpleCard(ItemChangeProto card, out bool r)
	{
		r = default(bool);
		return false;
	}

	public void TutorialTest(int stage)
	{
	}

	public void DrawCardAgainSoFinish26()
	{
	}

	private void deferredPopCheck(Action callback)
	{
	}

	private void checkAgain()
	{
	}

	private bool isUIScene()
	{
		return false;
	}

	public void ShowPreemBonus(int level, int crystal)
	{
	}

	private void notFinishedSoLaunch(int stage, bool squeeze = false)
	{
	}

	public bool IsStillForce()
	{
		return false;
	}

	private void OnClick()
	{
	}

	private bool isTutorialBegan(int t)
	{
		return false;
	}

	private bool started(int t)
	{
		return false;
	}

	private void handleMessage(string tagStr)
	{
	}

	private void single(string[] splitted)
	{
	}

	private void multi(string[] splitted)
	{
	}

	private void openUI(string stageID, bool squeeze)
	{
	}

	private void squeezer(GameObject go)
	{
	}

	private void closeUI()
	{
	}

	private void Update()
	{
	}

	public void Judge()
	{
	}

	private string createEventName()
	{
		return null;
	}

	private bool testExclusion(int i)
	{
		return false;
	}

	private bool isProgressFinished()
	{
		return false;
	}

	private bool isBitArrayEqual(BitArray a, BitArray b)
	{
		return false;
	}

	private void reset()
	{
	}

	public void TellServerAllGuidanceFinished()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause()
	{
	}

	public void CommitNewStageData()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitAndCommit_003Ed__103))]
	private IEnumerator waitAndCommit()
	{
		return null;
	}

	private void commitData()
	{
	}

	public void CommitTutorial6Finished()
	{
	}

	public void CommitTutorial7Finished()
	{
	}

	private void commitStageFinished(int stage, Action onShit = null)
	{
	}

	public static Mesh CreateMesh(bool half, float w, float h, Vector2 p, float vW, float vH)
	{
		return null;
	}

	private static void createVerts(bool half, ref Vector3[] verts, int i, float z, float w, float h, Vector2 p, float vW, float vH)
	{
	}
}
