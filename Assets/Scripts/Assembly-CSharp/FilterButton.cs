using System;
using UnityEngine;

public class FilterButton : MonoBehaviour
{
	public UIEventListener eventBtn;

	public UILabel lbText;

	public string[] FilterOptions;

	public string TitleHintText;

	public Action<int> E_OnChoosed;

	public void Start()
	{
	}

	public void OpenPopup()
	{
	}
}
