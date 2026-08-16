using System;
using UnityEngine;
using UnityEngine.UI;

public class UINameYouWebGL : MonoBehaviour
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

	[SerializeField]
	private InputField input;

	[SerializeField]
	private Button diceBtn;

	[SerializeField]
	private Button confirmBtn;

	public Action<string> OnSuccess;

	private void Start()
	{
	}

	private void OnClickDice()
	{
	}

	private void OnClickConfimr()
	{
	}

	private NameInValid InputFilter(string userName)
	{
		return default(NameInValid);
	}

	private int GetNameLength(string str)
	{
		return 0;
	}

	public static UINameYouWebGL Show(Transform parent = null)
	{
		return null;
	}
}
