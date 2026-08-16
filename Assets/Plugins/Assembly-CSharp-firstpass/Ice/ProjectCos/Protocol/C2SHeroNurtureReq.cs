using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroNurtureReq")]
	public class C2SHeroNurtureReq : IExtensible
	{
		[ProtoContract(Name = "NurtureType")]
		public enum NurtureType
		{
			[ProtoEnum(Name = "Normal", Value = 0)]
			Normal = 0,
			[ProtoEnum(Name = "NormalX10", Value = 1)]
			NormalX10 = 1,
			[ProtoEnum(Name = "Advanced", Value = 2)]
			Advanced = 2,
			[ProtoEnum(Name = "AdvancedX10", Value = 3)]
			AdvancedX10 = 3,
			[ProtoEnum(Name = "AutoNormalX10", Value = 4)]
			AutoNormalX10 = 4,
			[ProtoEnum(Name = "AutoNormalX20", Value = 5)]
			AutoNormalX20 = 5,
			[ProtoEnum(Name = "AutoNormalX50", Value = 6)]
			AutoNormalX50 = 6,
			[ProtoEnum(Name = "AutoAdvancedX10", Value = 7)]
			AutoAdvancedX10 = 7,
			[ProtoEnum(Name = "AutoAdvancedX20", Value = 8)]
			AutoAdvancedX20 = 8,
			[ProtoEnum(Name = "AutoAdvancedX50", Value = 9)]
			AutoAdvancedX50 = 9
		}

		private NurtureType _Type;

		private int _HeroIndex;

		private byte[] _Selections1;

		private byte[] _Selections2;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public NurtureType Type
		{
			get
			{
				return default(NurtureType);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Selections1", DataFormat = DataFormat.TwosComplement)]
		public byte[] Selections1
		{
			get => _Selections1;
			set => _Selections1 = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Selections2", DataFormat = DataFormat.TwosComplement)]
		public byte[] Selections2
		{
			get => _Selections2;
			set => _Selections2 = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
