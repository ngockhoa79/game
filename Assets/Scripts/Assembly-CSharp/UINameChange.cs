using System;
using UnityEngine;

public class UINameChange : IceUIBase
{
	public enum NameInValid
	{
		Valid = 0,
		Empty = 1,
		DefaultOrSubOfDefault = 2,
		SensiviveIncluded = 3,
		MaxLength = 4
	}

	private int MaxLenght;

	public UIEventListener DiceBtn;

	public UIEventListener ConfirmBtn;

	public UIEventListener CloseArea;

	public UIInput InputName;

	public IceAnimatorTotalCommander anim_in;

	public Action<string> E_OnSuccess;

	public Action E_OnClose;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private char handleValidate(string text, int index, char added)
	{
		return '\0';
	}

	private void handleNameYou(GameObject btn)
	{
	}

	private void handleDice(GameObject btn)
	{
	}

	private NameInValid inputFilter(string userName)
	{
		return default(NameInValid);
	}

	private int getLength(string str)
	{
		return 0;
	}

	private void pop(string msg)
	{
	}
}
