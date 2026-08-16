using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RankingItemProto")]
	public class RankingItemProto : IExtensible
	{
		private ulong _PlayerId;

		private string _Name;

		private int _Level;

		private int _LeaderId;

		private int _Ranking;

		private int _CombatValue;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong PlayerId
		{
			get => _PlayerId;
			set => _PlayerId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get => _Name;
			set => _Name = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "LeaderId", DataFormat = DataFormat.TwosComplement)]
		public int LeaderId
		{
			get => _LeaderId;
			set => _LeaderId = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "CombatValue", DataFormat = DataFormat.TwosComplement)]
		public int CombatValue
		{
			get => _CombatValue;
			set => _CombatValue = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
