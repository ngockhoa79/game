using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SLimitLotteryPickReq")]
	public class C2SLimitLotteryPickReq : IExtensible
	{
		private bool _IsNormal;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsNormal", DataFormat = DataFormat.Default)]
		public bool IsNormal
		{
			get => _IsNormal;
			set => _IsNormal = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
