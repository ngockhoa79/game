using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}
}
