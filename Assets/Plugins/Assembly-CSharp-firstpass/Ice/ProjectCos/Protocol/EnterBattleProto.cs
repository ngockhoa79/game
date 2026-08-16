using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EnterBattleProto")]
	public class EnterBattleProto : IExtensible
	{
		private bool _IsLeft;

		private int _Column;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsLeft", DataFormat = DataFormat.Default)]
		public bool IsLeft
		{
			get => _IsLeft;
			set => _IsLeft = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Column", DataFormat = DataFormat.TwosComplement)]
		public int Column
		{
			get => _Column;
			set => _Column = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
