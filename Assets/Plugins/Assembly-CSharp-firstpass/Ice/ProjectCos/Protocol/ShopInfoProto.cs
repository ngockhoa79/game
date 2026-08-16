using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ShopInfoProto")]
	public class ShopInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ShopItemProto")]
		public class ShopItemProto : IExtensible
		{
			private ItemChangeProto.ItemType _Type;

			private int _Id;

			private int _Count;

			private PropertyInfoProto.PropertyType _PayType;

			private int _Price;

			private bool _IsAlreadyBuy;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
			public ItemChangeProto.ItemType Type
			{
				get
				{
					return default(ItemChangeProto.ItemType);
				}
				set
				{
				}
			}

			[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "PayType", DataFormat = DataFormat.TwosComplement)]
			public PropertyInfoProto.PropertyType PayType
			{
				get
				{
					return default(PropertyInfoProto.PropertyType);
				}
				set
				{
				}
			}

			[ProtoMember(5, IsRequired = true, Name = "Price", DataFormat = DataFormat.TwosComplement)]
			public int Price
			{
				get => _Price;
				set => _Price = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "IsAlreadyBuy", DataFormat = DataFormat.Default)]
			public bool IsAlreadyBuy
			{
				get => _IsAlreadyBuy;
				set => _IsAlreadyBuy = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<ShopItemProto> _Items;

		private int _BuyRefreshTimes;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ShopItemProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "BuyRefreshTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyRefreshTimes
		{
			get => _BuyRefreshTimes;
			set => _BuyRefreshTimes = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
