using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CActivityOpenBoxAck")]
	public class S2CActivityOpenBoxAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2,
			[ProtoEnum(Name = "IdError", Value = 3)]
			IdError = 3,
			[ProtoEnum(Name = "TimesIsOutRange", Value = 4)]
			TimesIsOutRange = 4,
			[ProtoEnum(Name = "PrevIsNotOpen", Value = 5)]
			PrevIsNotOpen = 5,
			[ProtoEnum(Name = "NoEnoughEnergy", Value = 6)]
			NoEnoughEnergy = 6,
			[ProtoEnum(Name = "PlayerLevelLess", Value = 7)]
			PlayerLevelLess = 7
		}

		private ResultCode _Code;

		private List<int> _OpenSigns;

		private ActivityOpenBoxListProto _ItemList;

		private int _UsedCount;

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

		[ProtoMember(2, Name = "OpenSigns", DataFormat = DataFormat.TwosComplement)]
		public List<int> OpenSigns

		{

			get => _OpenSigns;

			set => _OpenSigns = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "ItemList", DataFormat = DataFormat.Default)]
		public ActivityOpenBoxListProto ItemList
		{
			get => _ItemList;
			set => _ItemList = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "UsedCount", DataFormat = DataFormat.TwosComplement)]
		public int UsedCount
		{
			get => _UsedCount;
			set => _UsedCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
