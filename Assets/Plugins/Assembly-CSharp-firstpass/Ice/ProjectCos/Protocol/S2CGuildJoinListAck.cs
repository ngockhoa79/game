using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildJoinListAck")]
	public class S2CGuildJoinListAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "JoinInfoProto")]
		public class JoinInfoProto : IExtensible
		{
			private PlayerSummaryInfoProto _Player;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Player", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Player
			{
				get => _Player;
				set => _Player = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
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

		private ResultCode _Code;

		private List<JoinInfoProto> _Applicants;

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

		[ProtoMember(2, Name = "Applicants", DataFormat = DataFormat.Default)]
		public List<JoinInfoProto> Applicants

		{

			get => _Applicants;

			set => _Applicants = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
