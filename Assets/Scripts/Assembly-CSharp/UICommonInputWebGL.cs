using System;
using UnityEngine;
using UnityEngine.UI;

public class UICommonInputWebGL : MonoBehaviour
{
	public static UICommonInputWebGL Instance;

	public Button closeBtn;

	public Button confirmBtn;

	public InputField inputField;

	public Text titleTxt;

	public Action<string, string> E_OnInput;

	public Action<string> E_OnInputChangedOrSubmit;

	public string initText;

	public static UICommonInputWebGL ShowInput(string title, string initText, int length = -1, InputField.ContentType contentType = InputField.ContentType.Standard, Transform parent = null)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnInputValueChanged(string value)
	{
	}

	private void OnInputSubmit(string value)
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickConfirm()
	{
	}
}
