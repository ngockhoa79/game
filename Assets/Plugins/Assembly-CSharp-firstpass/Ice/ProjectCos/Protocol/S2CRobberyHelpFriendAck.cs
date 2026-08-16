using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRobberyHelpFriendAck")]
	public class S2CRobberyHelpFriendAck : IExtensible
	{
		private S2CRobberyRobAck.ResultCode _Code;

		private BattleReportProto _BattleReport;

		private int _FriendShipValue;

		private int _RobberyCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public S2CRobberyRobAck.ResultCode Code
		{
			get
			{
				return default(S2CRobberyRobAck.ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "FriendShipValue", DataFormat = DataFormat.TwosComplement)]
		public int FriendShipValue
		{
			get => _FriendShipValue;
			set => _FriendShipValue = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "RobberyCount", DataFormat = DataFormat.TwosComplement)]
		public int RobberyCount
		{
			get => _RobberyCount;
			set => _RobberyCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
