using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIProtocolContentPanel : MonoBehaviour
{
	private static UIProtocolContentPanel panel;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Button yesBtn;

	[SerializeField]
	private Button noBtn;

	[SerializeField]
	private List<Text> txts;

	private readonly Dictionary<string, string> urlMap;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnClickYes()
	{
	}

	private void OnClickNo()
	{
	}

	public void ShowPanel(string url)
	{
	}

	private List<string> SplitText(string text)
	{
		return null;
	}

	public static void Show(string url)
	{
	}
}
