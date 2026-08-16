using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonPickScoreRankingAck")]
	public class S2CCrossPersonPickScoreRankingAck : IExtensible
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
			[ProtoEnum(Name = "LevelLess", Value = 3)]
			LevelLess = 3,
			[ProtoEnum(Name = "PickNotEnabel", Value = 4)]
			PickNotEnabel = 4
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private List<ThingProto> _Comebackthings;

		private List<ThingProto> _NormalRewards;

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

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(3, Name = "Comebackthings", DataFormat = DataFormat.Default)]
		public List<ThingProto> Comebackthings

		{

			get => _Comebackthings;

			set => _Comebackthings = value;

		}

		[ProtoMember(4, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ThingProto> NormalRewards

		{

			get => _NormalRewards;

			set => _NormalRewards = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
