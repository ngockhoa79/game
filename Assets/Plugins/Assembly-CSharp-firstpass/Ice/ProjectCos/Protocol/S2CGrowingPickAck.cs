using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGrowingPickAck")]
	public class S2CGrowingPickAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2,
			[ProtoEnum(Name = "OutOfPickRange", Value = 3)]
			OutOfPickRange = 3,
			[ProtoEnum(Name = "LevelLess", Value = 4)]
			LevelLess = 4,
			[ProtoEnum(Name = "AlreadyPick", Value = 5)]
			AlreadyPick = 5
		}

		private ResultCode _Code;

		private int _IndexMark;

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

		[ProtoMember(2, IsRequired = true, Name = "IndexMark", DataFormat = DataFormat.TwosComplement)]
		public int IndexMark
		{
			get => _IndexMark;
			set => _IndexMark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
