using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "NormalAttackProto")]
	public class NormalAttackProto : IExtensible
	{
		private int _EffectId;

		private int _BatterCount;

		private HarmInfoProto _Harm;

		private List<BuffActionEffectProto> _OtherBuffEffects;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "EffectId", DataFormat = DataFormat.TwosComplement)]
		public int EffectId
		{
			get => _EffectId;
			set => _EffectId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BatterCount", DataFormat = DataFormat.TwosComplement)]
		public int BatterCount
		{
			get => _BatterCount;
			set => _BatterCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Harm", DataFormat = DataFormat.Default)]
		public HarmInfoProto Harm
		{
			get => _Harm;
			set => _Harm = value;
		}

		[ProtoMember(4, Name = "OtherBuffEffects", DataFormat = DataFormat.Default)]
		public List<BuffActionEffectProto> OtherBuffEffects

		{

			get => _OtherBuffEffects;

			set => _OtherBuffEffects = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
