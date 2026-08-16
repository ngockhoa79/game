using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("SquanderGuidance")]
public class LoadDraft : FsmStateAction
{
	private const string Draft_Path = "UI/SquanderGuidance/Draft/";

	private Init init;

	private GameObject go;

	public int Frames;

	public override void OnEnter()
	{
	}

	private void loadDraft()
	{
	}

	public override void OnExit()
	{
	}
}
