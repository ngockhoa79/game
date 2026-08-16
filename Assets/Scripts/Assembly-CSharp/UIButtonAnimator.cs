using UnityEngine;

public class UIButtonAnimator : MonoBehaviour
{
	[SerializeField]
	private string effectName;

	[SerializeField]
	private GameObject defaultTarget;

	private bool bAnimating;

	private const string ResType = "uieffects";

	private IceAnimatorTotalCommander animator;

	private GameObject animatorGo;

	private GameObject DefaultTarget => null;

	private void OnClick()
	{
	}

	private void CreateAnimator()
	{
	}

	private void Clear()
	{
	}
}
