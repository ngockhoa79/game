using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SDuplicateBuyLimitTimesReq")]
	public class C2SDuplicateBuyLimitTimesReq : IExtensible
	{
		private C2SDuplicateReportReq.DuplicateType _Type;

		private int _DuplicateId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SDuplicateReportReq.DuplicateType Type
		{
			get
			{
				return default(C2SDuplicateReportReq.DuplicateType);
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
