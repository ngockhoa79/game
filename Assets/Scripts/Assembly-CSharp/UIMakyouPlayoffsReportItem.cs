using System;

public class UIMakyouPlayoffsReportItem : IceUIBase
{
	public UISprite SpriteIndex;

	public UIAeCardDisplayer PlayerIcon;

	public UILabel PlayerName;

	public UILabel PlayerLevel;

	public UILabel ServerNo;

	public UILabel HappenTime;

	public UIEventListener ButtonReplay;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	private MakyouPlayoffsReportItemData ItemData;

	private void Clear()
	{
	}

	public void SetData(MakyouPlayoffsReportItemData data)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
