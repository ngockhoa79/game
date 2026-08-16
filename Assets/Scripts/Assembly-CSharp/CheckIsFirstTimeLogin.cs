using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class CheckIsFirstTimeLogin : FsmStateAction
{
	private enum State
	{
		Failed = 0,
		FirstTime = 1,
		NotFirstTime = 2
	}

	[RequiredField]
	public FsmEvent E_IsFirstTime;

	[RequiredField]
	public FsmEvent E_NotFirstTime;

	[RequiredField]
	public FsmEvent E_Failed;

	private bool bFirstTime;

	private State _state;

	public override void OnEnter()
	{
		DebugLog.Log("CheckIsFirstTimeLogin.OnEnter");
		Defer.getRunner().StartCoroutine(LoadFromLocalVersion());
	}

	private IEnumerator LoadFromLocalVersion()
	{
		string localVersionPath = UnityEngine.Application.persistentDataPath + "/downloadRecord.txt";
		DebugLog.Log("CheckIsFirstTimeLogin checking localVersionPath: " + localVersionPath);

		bool fileExists = false;
		try
		{
			fileExists = System.IO.File.Exists(localVersionPath);
		}
		catch (Exception ex)
		{
			DebugLog.LogError("CheckIsFirstTimeLogin error checking file: " + ex);
		}

		yield return null;

		if (fileExists)
		{
			bFirstTime = false;
			_state = State.NotFirstTime;
			Success();
		}
		else
		{
			bFirstTime = true;
			_state = State.FirstTime;
			Success();
		}
	}

	private void Failed()
	{
		var ev = (E_Failed != null && !string.IsNullOrEmpty(E_Failed.Name)) ? E_Failed : FsmEvent.GetFsmEvent("Fail");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}

	private void Success()
	{
		if (_state == State.FirstTime)
		{
			var ev = (E_IsFirstTime != null && !string.IsNullOrEmpty(E_IsFirstTime.Name)) ? E_IsFirstTime : FsmEvent.GetFsmEvent("IsFirstTime");
			if (Fsm != null && ev != null)
			{
				Fsm.Event(ev);
			}
		}
		else if (_state == State.NotFirstTime)
		{
			var ev = (E_NotFirstTime != null && !string.IsNullOrEmpty(E_NotFirstTime.Name)) ? E_NotFirstTime : FsmEvent.GetFsmEvent("NotFirstTime");
			if (Fsm != null && ev != null)
			{
				Fsm.Event(ev);
			}
		}
		Finish();
	}
}


