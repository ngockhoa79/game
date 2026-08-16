using UnityEngine;

public class HUDFPS : MonoBehaviour
{
	public float updateInterval;

	public bool bDetectLeaks;

	public UILabel lbFps;

	private bool bShow;

	private float accum;

	private int frames;

	private float timeleft;

	private float fps;

	private int curFrameRate;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
