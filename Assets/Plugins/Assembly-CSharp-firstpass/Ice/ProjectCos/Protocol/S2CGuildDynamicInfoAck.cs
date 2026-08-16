using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildDynamicInfoAck")]
	public class S2CGuildDynamicInfoAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "DynamicInfoProto")]
		public class DynamicInfoProto : IExtensible
		{
			private PlayerSummaryInfoProto _Player;

			private OperatorTypeEnum _OperatorTyp;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Player", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Player
			{
				get => _Player;
				set => _Player = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "OperatorTyp", DataFormat = DataFormat.TwosComplement)]
			public OperatorTypeEnum OperatorTyp
			{
				get
				{
					return default(OperatorTypeEnum);
				}
				set
				{
				}
			}

			[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 2)]
			NoGuild = 2
		}

		[ProtoContract(Name = "OperatorTypeEnum")]
		public enum OperatorTypeEnum
		{
			[ProtoEnum(Name = "Join", Value = 1)]
			Join = 1,
			[ProtoEnum(Name = "Leave", Value = 2)]
			Leave = 2,
			[ProtoEnum(Name = "Promote", Value = 3)]
			Promote = 3,
			[ProtoEnum(Name = "Transfer", Value = 4)]
			Transfer = 4,
			[ProtoEnum(Name = "Demote", Value = 5)]
			Demote = 5,
			[ProtoEnum(Name = "Kick", Value = 6)]
			Kick = 6
		}

		private ResultCode _Code;

		private List<DynamicInfoProto> _Infos;

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

		[ProtoMember(2, Name = "Infos", DataFormat = DataFormat.Default)]
		public List<DynamicInfoProto> Infos

		{

			get => _Infos;

			set => _Infos = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
