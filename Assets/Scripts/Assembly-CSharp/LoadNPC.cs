using HutongGames.PlayMaker;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

[ActionCategory("SquanderGuidance")]
public class LoadNPC : FsmStateAction
{
	public enum POSITION
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	private const string Card_Images_Dialog = "card_images_dialog";

	private const string TransparentBlank = "Texture/TransparentBlank";

	private Init init;

	public int NPCID;

	public POSITION NPCPosition;

	public string Sentence;

	private UITexture LeftNPC;

	private UITexture RightNPC;

	private static Timer typeWriterTimer;

	public override void OnEnter()
	{
	}

	private void setupNPC()
	{
	}

	private void CheckNpcEm(bool _left, TheTutorialTemplate _temp)
	{
	}

	private string formatSentenceWithName(string original)
	{
		return null;
	}

	private void resetAllAnims(IceAnimatorTotalCommander a, IceAnimatorTotalCommander b, IceAnimatorTotalCommander c, IceAnimatorTotalCommander d, IceAnimatorTotalCommander e)
	{
	}

	private string getConfigByActiveState()
	{
		return null;
	}

	public override void OnExit()
	{
	}

	private void reActivateTypeWriter(string txt, GameObject go)
	{
	}

	private void transparentNPC()
	{
	}

	public static void CompleteTypeWriter()
	{
	}

	private void lullEvent(GameObject go, string txt)
	{
	}

	private void lull(bool working)
	{
	}
}
