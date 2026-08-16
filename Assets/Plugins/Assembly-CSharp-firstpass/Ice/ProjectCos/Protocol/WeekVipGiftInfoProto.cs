using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "WeekVipGiftInfoProto")]
	public class WeekVipGiftInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			private long _StartTime;

			private long _EndTime;

			private List<VipGiftConfig> _GiftConfig;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "StartTime", DataFormat = DataFormat.TwosComplement)]
			public long StartTime
			{
				get => _StartTime;
				set => _StartTime = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "EndTime", DataFormat = DataFormat.TwosComplement)]
			public long EndTime
			{
				get => _EndTime;
				set => _EndTime = value;
			}

			[ProtoMember(3, Name = "GiftConfig", DataFormat = DataFormat.Default)]
			public List<VipGiftConfig> GiftConfig

			{

				get => _GiftConfig;

				set => _GiftConfig = value;

			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "VipGiftConfig")]
		public class VipGiftConfig : IExtensible
		{
			private int _Vip;

			private int _Sale;

			private int _Original;

			private List<ThingProto> _Rewards;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Vip", DataFormat = DataFormat.TwosComplement)]
			public int Vip
			{
				get => _Vip;
				set => _Vip = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Sale", DataFormat = DataFormat.TwosComplement)]
			public int Sale
			{
				get => _Sale;
				set => _Sale = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Original", DataFormat = DataFormat.TwosComplement)]
			public int Original
			{
				get => _Original;
				set => _Original = value;
			}

			[ProtoMember(4, Name = "Rewards", DataFormat = DataFormat.Default)]
			public List<ThingProto> Rewards

			{

				get => _Rewards;

				set => _Rewards = value;

			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "VipGiftInfo")]
		public class VipGiftInfo : IExtensible
		{
			private int _VipLevel;

			private bool _IsAlready;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "VipLevel", DataFormat = DataFormat.TwosComplement)]
			public int VipLevel
			{
				get => _VipLevel;
				set => _VipLevel = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "IsAlready", DataFormat = DataFormat.Default)]
			public bool IsAlready
			{
				get => _IsAlready;
				set => _IsAlready = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<VipGiftInfo> _Vip;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Skills", DataFormat = DataFormat.Default)]
		public List<VipGiftInfo> Vip

		{

			get => _Vip;

			set => _Vip = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
