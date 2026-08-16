using System;
using UnityEngine;
using UnityEngine.UI;

public class UINameChangeWebGL : MonoBehaviour
{
	public enum NameInValid
	{
		Valid = 0,
		Empty = 1,
		DefaultOrSubOfDefault = 2,
		SensiviveIncluded = 3,
		MaxLength = 4
	}

	public static UINameChangeWebGL Instance;

	private int MaxLenght;

	public Button DiceBtn;

	public Button ConfirmBtn;

	public Button CloseArea;

	public InputField InputName;

	public Action<string> E_OnSuccess;

	public Action E_OnClose;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void handleNameYou()
	{
	}

	private void handleDice()
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
