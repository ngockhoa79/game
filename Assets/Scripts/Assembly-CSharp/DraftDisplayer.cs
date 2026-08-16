using System;
using UnityEngine;

public class DraftDisplayer : MonoBehaviour
{
	public enum AnimType
	{
		None = 0,
		Begin = 1,
		Change = 2
	}

	private const string Card_Images_Dialog = "card_images_dialog";

	private const string Draft_Path = "UI/SquanderGuidance/Draft/";

	public IceAnimatorTotalCommander Begin;

	public IceAnimatorTotalCommander Change;

	public UILabel NPCName;

	public UILabel StoryLabel;

	public UITexture NPC;

	public Transform Root;

	private static Timer typeWriterTimer;

	public void Set(AnimType t, string npc_, string draft_, string dialog_, string name_, Action callback)
	{
	}

	private void reActivateTypeWriter(string txt, GameObject go)
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
