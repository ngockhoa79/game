using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class PreludeManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CdeserializeBin_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PreludeManager _003C_003E4__this;

		public Action deserialized;

		private WWW _003Cwww_003E5__2;

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
		public _003CdeserializeBin_003Ed__61(int _003C_003E1__state)
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

	public static bool IsUnderGuidance;

	private const string TransTxt = "Texture/TransparentBlank";

	private const string ResType = "card_images_dialog";

	private const string AudioKind = "bgm_no_stream";

	private const string BGM1 = "Cos_Tutoial_Bgm";

	private const string BGM2 = "Cos_Tutoial_Bgm2";

	private const string fileUrl = "file://";

	private const string androidFileUrl = "jar:file://";

	private const string binPath = "BattleShow.bin";

	private const int BEFORE_GIVE_NAME = 1;

	private const int AFTER_GIVE_NAME = 2;

	public IceAnimatorTotalCommander[] Blocks;

	public GameObject[] BlockObjects;

	public float[] BlockDurations;

	public float[] TypeWriterDurations;

	public UILabel BlockLabel;

	public IceAnimatorTotalCommander Read2Game;

	public IceAnimatorTotalCommander NPCLeftShow;

	public IceAnimatorTotalCommander NPCRightShow;

	public IceAnimatorTotalCommander LeftNPCShake;

	public IceAnimatorTotalCommander RightNPCShake;

	public UITexture LeftNPC;

	public UITexture RightNPC;

	public UILabel LeftNPCName;

	public UILabel RightNPCName;

	public UILabel DialogLabel;

	public UIEventListener Driver;

	public UIEventListener Skip;

	public IceAnimatorTotalCommander SkipAnim;

	public IceNGUIAlphaAnimator SkipCoverAnim;

	public UINameYou NameYouUI;

	private List<NewPlayerStoryTemplate> stories_before;

	private List<NewPlayerStoryTemplate> stories_after;

	private List<NewPlayerStoryTemplate> stories_current;

	private Action onFinished;

	private const int Left = 1;

	private const int Right = 2;

	private int step;

	private int blockIndex;

	private bool driverEnable;

	private Timer timer;

	private NewPlayerStoryTemplate[] allStories;

	public GameObject BattleScene;

	public GameObject MaskGroup;

	public GameObject DialogGroup;

	private BattleReport report;

	private void Awake()
	{
	}

	private void readStoryConfiguration()
	{
	}

	private void dig(ref List<NewPlayerStoryTemplate> l, int i)
	{
	}

	private void OnDestroy()
	{
	}

	private void skipToBattle(GameObject btn)
	{
	}

	private void activateSkip(bool active)
	{
	}

	private void nextStep(GameObject btn)
	{
	}

	private void invokeTimerEvent()
	{
	}

	private void Start()
	{
	}

	private void playBlocks()
	{
	}

	private void playBlock(int i, Action done)
	{
	}

	private void playBlock(IceAnimatorTotalCommander b, UILabel l, string str, Action done, float duration, float tD)
	{
	}

	private NewPlayerStoryTemplate newStory(NewPlayerStoryTemplate t, string arg)
	{
		return null;
	}

	private void playBattleEntrance()
	{
	}

	private void playAfterBinPlayed()
	{
	}

	[IteratorStateMachine(typeof(_003CdeserializeBin_003Ed__61))]
	private IEnumerator deserializeBin(Action deserialized)
	{
		return null;
	}

	private void playBattleShow()
	{
	}

	private void playEndingStory_beforeGiveName()
	{
	}

	private void bringNameYouUI()
	{
	}

	private void playEndingStory_afterGiveName()
	{
	}

	private List<NewPlayerStoryTemplate> formatStories(List<NewPlayerStoryTemplate> src)
	{
		return null;
	}

	private void enterMainStage()
	{
	}

	private void reproduce(List<NewPlayerStoryTemplate> stories, Action onFinished)
	{
	}

	private void reproduceOneStory(NewPlayerStoryTemplate story)
	{
	}

	private void handleStretchLabel(UILabel label, string txt)
	{
	}

	private void setNPCName(UILabel label, string n)
	{
	}

	private void stopPreviousStory()
	{
	}
}
