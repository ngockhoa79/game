using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Sound2")]
public class UIPlaySound2 : MonoBehaviour
{
	public enum Trigger
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		OnAnimatorTotalCommander = 5,
		OnActive = 6,
		OnStart = 7,
		Custom = 8
	}

	public const string ResCategorType = "sound_nostream";

	public UISoundName audioName;

	public Trigger trigger;

	private bool mIsOver;

	[Range(0f, 1f)]
	public float volume;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Play()
	{
	}
}
