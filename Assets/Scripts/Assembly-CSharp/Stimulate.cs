using System;
using UnityEngine;

public class Stimulate : MonoBehaviour
{
	public PlayMakerFSM FSM;

	public Init initBehaviour;

	private int id;

	private string codeName;

	private string codeValue;

	private Type ackType;

	private string nextStep;

	public void StepTo(string step)
	{
	}

	private void handleOnResponse(int ackID, object response)
	{
	}

	private bool checkCode(object response)
	{
		return false;
	}

	private void handleOnFailure(int ackID, Action fallback)
	{
	}

	private void handleOnSent(int ackID)
	{
	}

	public static float AnchorFix(bool force, float x, bool fromBattleScene = false)
	{
		return 0f;
	}

	public static float AnchorLeftFix(bool force, float x, bool fromBattleScene = false)
	{
		return 0f;
	}
}
