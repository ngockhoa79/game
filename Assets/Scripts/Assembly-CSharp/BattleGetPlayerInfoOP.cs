using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.GameOperations;

public class BattleGetPlayerInfoOP : Operation
{
	public int PlayerID { get; private set; }

	public PlayerSummaryInfoProto PlayerInfo { get; private set; }

	public BattleGetPlayerInfoOP(int playerID)
		: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
	{
	}

	public override object BuildRequest()
	{
		return null;
	}

	protected override void ApplyChanges(object response)
	{
	}
}
