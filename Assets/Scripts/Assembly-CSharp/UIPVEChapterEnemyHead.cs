public class UIPVEChapterEnemyHead : IceUIBase
{
	public enum DuplicationType
	{
		None = 0,
		Elite = 1,
		Boss = 2,
		Quest = 3,
		Battle = 4
	}

	public enum QuestType
	{
		None = 0,
		Sign = 1,
		Finish = 2
	}

	public UIAeSingleCardDisplayer displayer;

	public UISprite iconBattle;

	public UISprite iconBoss;

	public UISprite iconMissionSign;

	public UISprite iconMissionFinish;

	public UISprite iconElite;

	protected override void DoPrepare()
	{
	}

	public void SetData(int heroId, DuplicationType thisType)
	{
	}

	public void ShowMission(QuestType _type)
	{
	}

	protected void ShowTag(DuplicationType _type)
	{
	}

	protected override void DoDispose()
	{
	}
}
