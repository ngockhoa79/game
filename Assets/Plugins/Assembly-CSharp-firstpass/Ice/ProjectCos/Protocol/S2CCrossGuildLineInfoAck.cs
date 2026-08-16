using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossGuildLineInfoAck")]
	public class S2CCrossGuildLineInfoAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "CellPlayerInfoProto")]
		public class CellPlayerInfoProto : IExtensible
		{
			private int _PostionIndex;

			private PlayerSummaryInfoProto _Sumamry;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PostionIndex", DataFormat = DataFormat.TwosComplement)]
			public int PostionIndex
			{
				get => _PostionIndex;
				set => _PostionIndex = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Sumamry", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Sumamry
			{
				get => _Sumamry;
				set => _Sumamry = value;
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
			[ProtoEnum(Name = "ArgumentError", Value = 4)]
			ArgumentError = 4
		}

		private ResultCode _Code;

		private List<CellPlayerInfoProto> _Infos;

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
		public List<CellPlayerInfoProto> Infos

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
