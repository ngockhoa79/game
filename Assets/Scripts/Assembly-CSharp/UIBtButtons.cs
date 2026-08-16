using UnityEngine;

public class UIBtButtons : MonoBehaviour
{
	public delegate bool VoidDelegate();

	public GameObject FastBtn;

	public GameObject SkipBtn;

	public UILabel fastTipLabel;

	public UILabel skipTipLabel;

	public IceAnimatorTotalCommander fastTipAnim;

	public IceAnimatorTotalCommander skipTipAnim;

	public VoidDelegate checkSkipHandled;

	private bool skipped;

	private bool speedUpCheatMode;

	public void ShowSkipBtn(bool _show)
	{
	}

	public void ResetSkipForReplay()
	{
	}

	public void StartSkipCount()
	{
	}

	public void OpenSpeedUpCheatMode()
	{
	}

	private void OnFast(GameObject btn)
	{
	}

	private void OnSkip(GameObject btn)
	{
	}

	private void Start()
	{
	}
}
