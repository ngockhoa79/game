using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFriendBattleAck")]
	public class S2CFriendBattleAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IsNoFriend", Value = 2)]
			IsNoFriend = 2,
			[ProtoEnum(Name = "MessageIsTooLength", Value = 3)]
			MessageIsTooLength = 3
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

		private int _Friendship;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
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

		[ProtoMember(3, IsRequired = true, Name = "Friendship", DataFormat = DataFormat.TwosComplement)]
		public int Friendship
		{
			get => _Friendship;
			set => _Friendship = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
