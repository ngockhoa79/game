using System;
using UnityEngine;

public class UINameYou : MonoBehaviour
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

	public UIInput InputName;

	public Action<string> OnSuccess;

	private void Start()
	{
	}

	private void OnDestroy()
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
