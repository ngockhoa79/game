using UnityEngine;

public class ChatBubble : MonoBehaviour
{
	private UISprite background;

	private UILabel text;

	public float LeftMargin;

	public float RightMargin;

	public float TopMargin;

	public float BottomMargin;

	public float FadeoutTimeSec;

	private long appearTime;

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void prepareWidgets()
	{
	}

	private void fitBkgnd()
	{
	}

	private void autoFadeout()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
