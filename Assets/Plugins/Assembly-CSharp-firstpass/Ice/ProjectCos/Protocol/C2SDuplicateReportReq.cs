using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SDuplicateReportReq")]
	public class C2SDuplicateReportReq : IExtensible
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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
