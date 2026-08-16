using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FinalCompetitionItemProro")]
	public class FinalCompetitionItemProro : IExtensible
	{
		private int _FighterId;

		private int _SpiritChange;

		private int _HpChange;

		private int _HpRemain;

		private int _SpiritRemain;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FighterId", DataFormat = DataFormat.TwosComplement)]
		public int FighterId
		{
			get => _FighterId;
			set => _FighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SpiritChange", DataFormat = DataFormat.TwosComplement)]
		public int SpiritChange
		{
			get => _SpiritChange;
			set => _SpiritChange = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "HpChange", DataFormat = DataFormat.TwosComplement)]
		public int HpChange
		{
			get => _HpChange;
			set => _HpChange = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "HpRemain", DataFormat = DataFormat.TwosComplement)]
		public int HpRemain
		{
			get => _HpRemain;
			set => _HpRemain = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "SpiritRemain", DataFormat = DataFormat.TwosComplement)]
		public int SpiritRemain
		{
			get => _SpiritRemain;
			set => _SpiritRemain = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
