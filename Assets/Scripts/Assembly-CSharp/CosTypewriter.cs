using UnityEngine;

[RequireComponent(typeof(UILabel))]
public class CosTypewriter : MonoBehaviour
{
	public int charsPerSecond;

	private UILabel mLabel;

	private string mText;

	private int mOffset;

	private float mNextChar;

	public void SetText(string str)
	{
	}

	private void LateUpdate()
	{
	}

	public static void ReActivateTypeWriter(string txt, GameObject go)
	{
	}

	public static void RemoveTypeWriter(GameObject go)
	{
	}
}
