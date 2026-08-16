using System.Collections.Generic;
using UnityEngine;

public class Editor_UIFightPanelCtrller : MonoBehaviour
{
	public UIPopupList typeList;

	public UIPopupList qualityList;

	public UIPopupList skillList;

	public Editor_BattleTestCtrller TestCtrller;

	public GameObject battleUITopbar;

	private bool started;

	private List<string> skillContentList;

	private int skillScrollCounter;

	private void Start()
	{
	}

	private void SkillDropDownAddScrollListener(GameObject _list)
	{
	}

	private void SkillDropDownScroll(GameObject _list, float _delta)
	{
	}

	private void Update()
	{
	}

	public void TypeChanged()
	{
	}

	public void QualityChanged()
	{
	}

	public void SkillChanged()
	{
	}

	public void PlayCurrentSkill(bool _left)
	{
	}

	private string GetSkillRealPrefabName(string _selectSkillItem)
	{
		return null;
	}

	private void FilterSkills()
	{
	}

	private bool qualityCorrect(char _quality)
	{
		return false;
	}
}
