using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RoundOverProto")]
	public class RoundOverProto : IExtensible
	{
		private bool _WinnerIsLeft;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "WinnerIsLeft", DataFormat = DataFormat.Default)]
		public bool WinnerIsLeft
		{
			get => _WinnerIsLeft;
			set => _WinnerIsLeft = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
