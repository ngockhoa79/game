using UnityEngine;

public class UIEffectsTester : MonoBehaviour
{
	public enum Mode
	{
		EnterAndDispose = 0,
		DisposeAndEnter = 1
	}

	public IceUIBase UI;

	public Mode mode;

	public bool Play;

	private bool cache;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
