using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRankIngListReq")]
	public class C2SRankIngListReq : IExtensible
	{
		private bool _IsForceRefresh;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsForceRefresh", DataFormat = DataFormat.Default)]
		public bool IsForceRefresh
		{
			get => _IsForceRefresh;
			set => _IsForceRefresh = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
