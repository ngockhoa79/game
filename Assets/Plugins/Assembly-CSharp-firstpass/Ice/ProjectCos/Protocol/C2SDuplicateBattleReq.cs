using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SDuplicateBattleReq")]
	public class C2SDuplicateBattleReq : IExtensible
	{
		[ProtoContract(Name = "DuplicateType")]
		public enum DuplicateType
		{
			[ProtoEnum(Name = "Normal", Value = 0)]
			Normal = 0,
			[ProtoEnum(Name = "Activity", Value = 1)]
			Activity = 1
		}

		private DuplicateType _Type;

		private int _DuplicateId;

		private int _Count;

		private ulong _ReplaceId;

		private int _ReplacePostion;

		private List<int> _ReplaceColumnIndexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public DuplicateType Type
		{
			get
			{
				return default(DuplicateType);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ReplaceId", DataFormat = DataFormat.TwosComplement)]
		public ulong ReplaceId
		{
			get => _ReplaceId;
			set => _ReplaceId = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "ReplacePostion", DataFormat = DataFormat.TwosComplement)]
		public int ReplacePostion
		{
			get => _ReplacePostion;
			set => _ReplacePostion = value;
		}

		[ProtoMember(6, Name = "ReplaceColumnIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReplaceColumnIndexs

		{

			get => _ReplaceColumnIndexs;

			set => _ReplaceColumnIndexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
