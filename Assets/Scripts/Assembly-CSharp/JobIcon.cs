using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class JobIcon : MonoBehaviour
{
	public enum IconType
	{
		Normal = 0,
		Big = 1,
		NoFrame = 2
	}

	public static string[] JobIconsNormal;

	public static string[] JobIconsBig;

	public static string[] JobIconsNoFrame;

	[HideInInspector]
	private string[] mUsingSpName;

	public IconType Type;

	public UISprite spProfessionIcon;

	private void Start()
	{
	}

	public void Set(EHeroProfession job)
	{
	}
}
