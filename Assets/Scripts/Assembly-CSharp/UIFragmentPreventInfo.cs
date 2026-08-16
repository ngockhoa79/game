using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFragmentPreventInfo : MonoBehaviour
{
	public enum Status
	{
		None = 0,
		Btn = 1,
		CD = 2
	}

	private const string TAG = "FragmentRobProtectTip";

	public UIEventListener PreventBtn;

	public UILabel CDLabel;

	public GameObject[] Parts;

	private int skillId;

	private Timer t;

	public Action<bool> OnPrevented;

	public void Set(Skill skill)
	{
	}

	private void internalSet(Status status, TimeSpan cd = default(TimeSpan))
	{
	}

	private void handlePrevent(GameObject btn)
	{
	}

	private void req(int crystal)
	{
	}

	private void tip(string t)
	{
	}

	private void dealWithCD(TimeSpan cd)
	{
	}

	private string patchDesc(string cd)
	{
		return null;
	}
}
