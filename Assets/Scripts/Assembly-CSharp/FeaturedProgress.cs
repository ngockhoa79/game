using UnityEngine;

public class FeaturedProgress : MonoBehaviour
{
	private UISprite Foreground;

	private UISprite Middle;

	private UISprite Background;

	private UISprite ForegroundAddtive;

	private UILabel TextLabel;

	private float barValue;

	public float Min;

	public float Max;

	[HideInInspector]
	public float currentValue;

	private float delaySec;

	private float timeToReduceAllSec;

	private float prevPercentage;

	private float delayTimer;

	private bool filling;

	private bool needFillup;

	private float fillSpeed;

	private float fillTarget;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

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

	private void prepareWidgets()
	{
	}

	public void StartFillUp()
	{
	}

	private void updateProgress()
	{
	}

	private void SetMiddleFillAmount(float _value)
	{
	}

	private void CalFillSpeed(float _gap)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
