using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEEventGroup : MonoBehaviour
{
	public delegate void H_ChapterClickDelegate(int chapterId);

	public UIPVEEventItem[] eventItems;

	public H_ChapterClickDelegate E_OnChapterClicked;

	public void SetData(EventGroup data)
	{
	}

	public void ClearData()
	{
	}

	private void OnChapterClicked(int chapterId)
	{
	}
}
