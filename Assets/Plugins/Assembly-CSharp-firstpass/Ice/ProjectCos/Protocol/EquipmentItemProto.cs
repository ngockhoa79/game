using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EquipmentItemProto")]
	public class EquipmentItemProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "AppendProperty")]
		public class AppendProperty : IExtensible
		{
			private PropertyChangeProto.TypeEnum _Type;

			private int _Value;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
			public PropertyChangeProto.TypeEnum Type
			{
				get
				{
					return default(PropertyChangeProto.TypeEnum);
				}
				set
				{
				}
			}

			[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
			public int Value
			{
				get => _Value;
				set => _Value = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "RefineInfoProto")]
		public class RefineInfoProto : IExtensible
		{
			private int _MajorAdditionalValue;

			private AppendProperty _Property1;

			private AppendProperty _Property2;

			private LockCodeEnum _LockCode;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "MajorAdditionalValue", DataFormat = DataFormat.TwosComplement)]
			public int MajorAdditionalValue
			{
				get => _MajorAdditionalValue;
				set => _MajorAdditionalValue = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Property1", DataFormat = DataFormat.Default)]
			public AppendProperty Property1
			{
				get => _Property1;
				set => _Property1 = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Property2", DataFormat = DataFormat.Default)]
			public AppendProperty Property2
			{
				get => _Property2;
				set => _Property2 = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "LockCode", DataFormat = DataFormat.TwosComplement)]
			public LockCodeEnum LockCode
			{
				get
				{
					return default(LockCodeEnum);
				}
				set
				{
				}
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "LockCodeEnum")]
		public enum LockCodeEnum
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "Only1", Value = 1)]
			Only1 = 1,
			[ProtoEnum(Name = "Only2", Value = 2)]
			Only2 = 2,
			[ProtoEnum(Name = "Both", Value = 3)]
			Both = 3
		}

		private int _Id;

		private int _Index;

		private int _Level;

		private int _MajorValue;

		private int _RefineLevel;

		private RefineInfoProto _CurRefineInfo;

		private RefineInfoProto _PrevRefineInfo;

		private bool _IsRefineReturnEnable;

		private int _LevelupCostGold;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "MajorValue", DataFormat = DataFormat.TwosComplement)]
		public int MajorValue
		{
			get => _MajorValue;
			set => _MajorValue = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "RefineLevel", DataFormat = DataFormat.TwosComplement)]
		public int RefineLevel
		{
			get => _RefineLevel;
			set => _RefineLevel = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "CurRefineInfo", DataFormat = DataFormat.Default)]
		public RefineInfoProto CurRefineInfo
		{
			get => _CurRefineInfo;
			set => _CurRefineInfo = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "PrevRefineInfo", DataFormat = DataFormat.Default)]
		public RefineInfoProto PrevRefineInfo
		{
			get => _PrevRefineInfo;
			set => _PrevRefineInfo = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "IsRefineReturnEnable", DataFormat = DataFormat.Default)]
		public bool IsRefineReturnEnable
		{
			get => _IsRefineReturnEnable;
			set => _IsRefineReturnEnable = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "LevelupCostGold", DataFormat = DataFormat.TwosComplement)]
		public int LevelupCostGold
		{
			get => _LevelupCostGold;
			set => _LevelupCostGold = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
