using UnityEngine;

public class LoginServerListVisualizer : IceUIReusableList<LoginServerPairData>.IVisualizer
{
	public readonly UILoginServerRoot Owner;

	public LoginServerListVisualizer(UILoginServerRoot owner)
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, LoginServerPairData item)
	{
	}

	public void ClearData(GameObject widget)
	{
	}
}
