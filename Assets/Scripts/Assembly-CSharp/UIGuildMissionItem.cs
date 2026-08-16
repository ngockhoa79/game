using UnityEngine;

public class UIGuildMissionItem : IceUIBase
{
	public Transform QuestIcon;

	public UILabel NameTitle;

	public UILabel Detail;

	public UILabel Progress;

	public GameObject ProgressMark;

	public UIEventListener Btn;

	public GameObject FinishBtn;

	public void SetData(GuildMissionItem item)
	{
	}

	private void GuildInternalNavigate(int _type)
	{
	}

	private void tipError()
	{
	}
}
