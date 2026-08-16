using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BattleFormationHeroProto")]
	public class BattleFormationHeroProto : IExtensible
	{
		private int _Postion;

		private PlayerHeroInfoProto _HeroInfo;

		private bool _IsLeader;

		private ulong _PlayerId;

		private bool _IsMonthCardExists;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Postion", DataFormat = DataFormat.TwosComplement)]
		public int Postion
		{
			get => _Postion;
			set => _Postion = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "HeroInfo", DataFormat = DataFormat.Default)]
		public PlayerHeroInfoProto HeroInfo
		{
			get => _HeroInfo;
			set => _HeroInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsLeader", DataFormat = DataFormat.Default)]
		public bool IsLeader
		{
			get => _IsLeader;
			set => _IsLeader = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong PlayerId
		{
			get => _PlayerId;
			set => _PlayerId = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "IsMonthCardExists", DataFormat = DataFormat.Default)]
		public bool IsMonthCardExists
		{
			get => _IsMonthCardExists;
			set => _IsMonthCardExists = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
