using Ice.ProjectCos.Protocol;

public class SkillRobSettlement
{
	public enum SkillRobSettlementType
	{
		Fail = 0,
		SuccessGet = 1,
		Makeup = 2
	}

	public SkillRobSettlementType settlementType;

	public int FragmentId;

	public int Money;

	public int FriendPoint;

	public ulong RobPlayerId;

	public SkillRobSettlement(S2CRobberyRobAck _ack, int _fragmentId, ulong _robPlayerId)
	{
	}

	public SkillRobSettlement(S2CRobberyRevengeAck _ack, int _fragmentId)
	{
	}

	public SkillRobSettlement(S2CRobberyHelpFriendAck _ack, int _fragmentId)
	{
	}

	public SkillRobSettlement()
	{
	}
}
