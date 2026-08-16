using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerRobberyInfoProto")]
	public class PlayerRobberyInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ProtectItemProto")]
		public class ProtectItemProto : IExtensible
		{
			private int _SkillId;

			private long _OverTime;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "SkillId", DataFormat = DataFormat.TwosComplement)]
			public int SkillId
			{
				get => _SkillId;
				set => _SkillId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
			public long OverTime
			{
				get => _OverTime;
				set => _OverTime = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _EnableCount;

		private long _LastRefreshCountTime;

		private int _BuyTimes;

		private List<ProtectItemProto> _Protects;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "EnableCount", DataFormat = DataFormat.TwosComplement)]
		public int EnableCount
		{
			get => _EnableCount;
			set => _EnableCount = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "LastRefreshCountTime", DataFormat = DataFormat.TwosComplement)]
		public long LastRefreshCountTime
		{
			get => _LastRefreshCountTime;
			set => _LastRefreshCountTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuyTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyTimes
		{
			get => _BuyTimes;
			set => _BuyTimes = value;
		}

		[ProtoMember(4, Name = "Protects", DataFormat = DataFormat.Default)]
		public List<ProtectItemProto> Protects

		{

			get => _Protects;

			set => _Protects = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
