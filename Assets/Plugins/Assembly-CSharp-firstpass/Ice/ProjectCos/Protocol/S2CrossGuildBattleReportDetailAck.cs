using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CrossGuildBattleReportDetailAck")]
	public class S2CrossGuildBattleReportDetailAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "NameInfoProto")]
		public class NameInfoProto : IExtensible
		{
			private ulong _PlayerId;

			private string _Name;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong PlayerId
			{
				get => _PlayerId;
				set => _PlayerId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
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
			NoGuild = 2,
			[ProtoEnum(Name = "GuldLevelLess", Value = 3)]
			GuldLevelLess = 3,
			[ProtoEnum(Name = "NoBattle", Value = 4)]
			NoBattle = 4
		}

		private ResultCode _Code;

		private BattleReportProto _ReportProto;

		private List<NameInfoProto> _Names;

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

		[ProtoMember(2, IsRequired = true, Name = "ReportProto", DataFormat = DataFormat.Default)]
		public BattleReportProto ReportProto
		{
			get => _ReportProto;
			set => _ReportProto = value;
		}

		[ProtoMember(3, Name = "Names", DataFormat = DataFormat.Default)]
		public List<NameInfoProto> Names

		{

			get => _Names;

			set => _Names = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
