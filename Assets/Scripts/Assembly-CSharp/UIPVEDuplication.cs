using System.Collections.Generic;
using UnityEngine;

public class UIPVEDuplication : MonoBehaviour
{
	public delegate void H_ChapterClickDelegate(int chapterId);

	public GameObject SlotPos;

	private List<UIPVESubDuplication> PVEDupList;

	public H_ChapterClickDelegate E_OnChapterClicked;

	private bool _bHideLast;

	public void SetData(bool bHideLast = false)
	{
		_bHideLast = bHideLast;
		ActiveDuplications(CfgProtoDuplication.DifficultyEnum.Normal);
	}

	private void ActiveDuplications(CfgProtoDuplication.DifficultyEnum difficulty)
	{
		PreSubDuplicationSettings(difficulty, 100);
	}

	private void OnSubDuplicationClicked(int chapterId)
	{
		E_OnChapterClicked?.Invoke(chapterId);
	}

	private void OnDestroy()
	{
	}

	public void SetDifficultyTo(CfgProtoDuplication.DifficultyEnum difficulty)
	{
		ActiveDuplications(difficulty);
	}

	private void PreSubDuplicationSettings(CfgProtoDuplication.DifficultyEnum difficulty, int chapterIdHead)
	{
		if (PVEDupList != null)
		{
			for (int i = 0; i < PVEDupList.Count; i++)
			{
				if (PVEDupList[i] != null)
				{
					PVEDupList[i].SetChapter(chapterIdHead + i);
				}
			}
		}
	}
}
