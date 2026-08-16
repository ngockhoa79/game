using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BuffDeleteProto")]
	public class BuffDeleteProto : IExtensible
	{
		private int _TargetFighterId;

		private int _BuffId;

		private int _BuffUniqueId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int TargetFighterId
		{
			get => _TargetFighterId;
			set => _TargetFighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BuffId", DataFormat = DataFormat.TwosComplement)]
		public int BuffId
		{
			get => _BuffId;
			set => _BuffId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuffUniqueId", DataFormat = DataFormat.TwosComplement)]
		public int BuffUniqueId
		{
			get => _BuffUniqueId;
			set => _BuffUniqueId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
