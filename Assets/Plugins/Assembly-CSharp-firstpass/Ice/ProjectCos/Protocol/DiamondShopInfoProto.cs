using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DiamondShopInfoProto")]
	public class DiamondShopInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ItemBuyTimesProto")]
		public class ItemBuyTimesProto : IExtensible
		{
			private int _Id;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<ItemBuyTimesProto> _DailyBuyInfo;

		private List<ItemBuyTimesProto> _TotalBuyInfo;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "DailyBuyInfo", DataFormat = DataFormat.Default)]
		public List<ItemBuyTimesProto> DailyBuyInfo

		{

			get => _DailyBuyInfo;

			set => _DailyBuyInfo = value;

		}

		[ProtoMember(2, Name = "TotalBuyInfo", DataFormat = DataFormat.Default)]
		public List<ItemBuyTimesProto> TotalBuyInfo

		{

			get => _TotalBuyInfo;

			set => _TotalBuyInfo = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
