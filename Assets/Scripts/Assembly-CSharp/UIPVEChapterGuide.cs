using System;
using UnityEngine;

public class UIPVEChapterGuide : IceUIBase
{
	[SerializeField]
	private UILabel lbLine1;

	[SerializeField]
	private UILabel lbLine2;

	[SerializeField]
	private UIEventListener btnNextButton;

	[SerializeField]
	private UIEventListener btnCurrButton;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	public Action E_OnLeave;

	public Action E_OnNext;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(int lastDuplicationId)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private string _get_unlock_string_(int chapterId)
	{
		return null;
	}

	private string _get_open_string_(int chapterId)
	{
		return null;
	}

	private string _get_chapter_name(int chapterId)
	{
		return null;
	}
}
