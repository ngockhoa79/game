using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ToNewLineProto")]
	public class ToNewLineProto : IExtensible
	{
		private int _TargetFighterId;

		private int _NewLine;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int TargetFighterId
		{
			get => _TargetFighterId;
			set => _TargetFighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "NewLine", DataFormat = DataFormat.TwosComplement)]
		public int NewLine
		{
			get => _NewLine;
			set => _NewLine = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
