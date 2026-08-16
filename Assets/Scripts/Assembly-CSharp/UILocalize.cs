using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/UI/Localize")]
public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnLocalize()
	{
	}
}
