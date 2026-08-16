using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Saved Option")]
public class UISavedOption : MonoBehaviour
{
	public string keyName;

	private UIPopupList mList;

	private UIToggle mCheck;

	private UIProgressBar mSlider;

	private string key => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SaveSelection()
	{
	}

	public void SaveState()
	{
	}

	public void SaveProgress()
	{
	}
}
