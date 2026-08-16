using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UICardLevelupSuccessCtrller : MonoBehaviour
{
	[SerializeField]
	private GameObject NormalSuccess;

	[SerializeField]
	private GameObject BigSuccess;

	[SerializeField]
	private GameObject ChaoSuccess;

	[SerializeField]
	private GameObject JiujiSuccess;

	public void Prepare()
	{
	}

	public void ShowResult(S2CHeroEatAck.ResultCode _code)
	{
	}
}
