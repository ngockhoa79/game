using UnityEngine;

public class TestReusableList : MonoBehaviour, IceUIReusableList<string>.IVisualizer
{
	public GameObject Prototype;

	public Transform List;

	public UIPanel Clipper;

	private IceUIReusableList<string> list;

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, string data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
