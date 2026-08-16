using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "HeroPropertyItemProto")]
	public class HeroPropertyItemProto : IExtensible
	{
		private int _BaseValue;

		private int _AdditionValue;

		private int _Multiplier;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseValue", DataFormat = DataFormat.TwosComplement)]
		public int BaseValue
		{
			get => _BaseValue;
			set => _BaseValue = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "AdditionValue", DataFormat = DataFormat.TwosComplement)]
		public int AdditionValue
		{
			get => _AdditionValue;
			set => _AdditionValue = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Multiplier", DataFormat = DataFormat.TwosComplement)]
		public int Multiplier
		{
			get => _Multiplier;
			set => _Multiplier = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
