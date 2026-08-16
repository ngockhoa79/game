using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIPVEEventItem : MonoBehaviour
{
	public delegate void H_OnClickedDelegate(int chapterId);

	private enum ChapterTimeStatus
	{
		None = 0,
		BeforeStart = 1,
		AfterEnd = 2,
		InProgress_WindowClosed = 3,
		InProgress_WindowOpen = 4,
		_NUM = 5
	}

	public UISprite ImgBase;

	public UISprite ImgSign;

	public UISprite ImgNew;

	public UILabel LblName;

	public UILabel LblRemainTime;

	public H_OnClickedDelegate E_OnClicked;

	public UIEventListener btnEvent;

	private int _chapterId;

	private ChapterTimeStatus chapterTimeStatus;

	private bool isOpen;

	public void SetData(int chapterId)
	{
	}

	public void ClearData()
	{
	}

	private void OnTimeCheck(CfgActivityDuplicateTemplate info)
	{
	}

	private void OnClicked(GameObject obj)
	{
	}
}
