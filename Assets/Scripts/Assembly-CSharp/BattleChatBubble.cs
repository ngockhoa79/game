using UnityEngine;

public class BattleChatBubble : MonoBehaviour
{
	public UISprite emoteSprite;

	public GameObject helpSprite;

	public GameObject shockSprite;

	public GameObject dialogLeft;

	public GameObject dialogRight;

	public UILabel leftTextLabel;

	public UILabel rightTextLabel;

	private bool showingEmote;

	private bool showingDialog;

	private bool autoClose;

	private float emoteTimer;

	private float dialogTimer;

	private void Update()
	{
	}

	public void ShowDialog(string _text, bool _left, bool _autoClose = false)
	{
	}

	public void ShowEmote(BattleEmoteType _type)
	{
	}

	private void HideDialogs()
	{
	}

	private void HideEmote()
	{
	}
}
