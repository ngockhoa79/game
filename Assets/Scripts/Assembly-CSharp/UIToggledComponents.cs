using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggled Components")]
[RequireComponent(typeof(UIToggle))]
[ExecuteInEditMode]
public class UIToggledComponents : MonoBehaviour
{
	public List<MonoBehaviour> activate;

	public List<MonoBehaviour> deactivate;

	[HideInInspector]
	[SerializeField]
	private MonoBehaviour target;

	[HideInInspector]
	[SerializeField]
	private bool inverse;

	private void Awake()
	{
	}

	public void Toggle()
	{
	}
}
