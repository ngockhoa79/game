using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2STrialReportDetailReq")]
	public class C2STrialReportDetailReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Stage", Value = 0)]
			Stage = 0,
			[ProtoEnum(Name = "SuperStage", Value = 1)]
			SuperStage = 1
		}

		private TypeEnum _Type;

		private int _Index;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
