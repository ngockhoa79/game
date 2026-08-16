using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "HeroNurtureInfoProto")]
	public class HeroNurtureInfoProto : IExtensible
	{
		private int _HpChange;

		private int _AttackChange;

		private int _DefenseChange;

		private int _SpiritChange;

		private int _PotentialReduce;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HpChange", DataFormat = DataFormat.TwosComplement)]
		public int HpChange
		{
			get => _HpChange;
			set => _HpChange = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "AttackChange", DataFormat = DataFormat.TwosComplement)]
		public int AttackChange
		{
			get => _AttackChange;
			set => _AttackChange = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "DefenseChange", DataFormat = DataFormat.TwosComplement)]
		public int DefenseChange
		{
			get => _DefenseChange;
			set => _DefenseChange = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "SpiritChange", DataFormat = DataFormat.TwosComplement)]
		public int SpiritChange
		{
			get => _SpiritChange;
			set => _SpiritChange = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "PotentialReduce", DataFormat = DataFormat.TwosComplement)]
		public int PotentialReduce
		{
			get => _PotentialReduce;
			set => _PotentialReduce = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
