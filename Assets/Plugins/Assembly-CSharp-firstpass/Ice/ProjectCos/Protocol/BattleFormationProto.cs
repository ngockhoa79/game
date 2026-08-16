using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BattleFormationProto")]
	public class BattleFormationProto : IExtensible
	{
		private ulong _PlayerId;

		private int _Column;

		private List<BattleFormationHeroProto> _HerosFormation;

		private List<int> _LeaderHeroIndexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong PlayerId
		{
			get => _PlayerId;
			set => _PlayerId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Column", DataFormat = DataFormat.TwosComplement)]
		public int Column
		{
			get => _Column;
			set => _Column = value;
		}

		[ProtoMember(3, Name = "HerosFormation", DataFormat = DataFormat.Default)]
		public List<BattleFormationHeroProto> HerosFormation

		{

			get => _HerosFormation;

			set => _HerosFormation = value;

		}

		[ProtoMember(4, Name = "LeaderHeroIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> LeaderHeroIndexs

		{

			get => _LeaderHeroIndexs;

			set => _LeaderHeroIndexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
