using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildFormationBinaryDataProto")]
	public class CrossGuildFormationBinaryDataProto : IExtensible
	{
		private byte[] _LeftLines;

		private byte[] _RightLines;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "LeftLines", DataFormat = DataFormat.Default)]
		public byte[] LeftLines
		{
			get => _LeftLines;
			set => _LeftLines = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RightLines", DataFormat = DataFormat.Default)]
		public byte[] RightLines
		{
			get => _RightLines;
			set => _RightLines = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
