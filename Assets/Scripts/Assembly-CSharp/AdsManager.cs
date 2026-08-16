using MYTOOL;
using UnityEngine;

public class AdsManager : MonoSingletonTemplate<AdsManager>
{
	[HideInInspector]
	public bool HasSDK;

	protected override void OnInit()
	{
	}
}
