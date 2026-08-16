using UnityEngine;

[ExecuteInEditMode]
public class AnimatedAlpha : MonoBehaviour
{
	[Range(0f, 1f)]
	public float alpha;

	private UIWidget mWidget;

	private UIPanel mPanel;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}
}
