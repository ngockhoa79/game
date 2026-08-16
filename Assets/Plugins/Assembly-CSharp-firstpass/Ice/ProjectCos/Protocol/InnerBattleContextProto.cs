using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "InnerBattleContextProto")]
	public class InnerBattleContextProto : IExtensible
	{
		private int _LeftJoinColCount;

		private int _RightJoinColCount;

		private int _TotalBoutCount;

		private int _LeftDeadedHerosCount;

		private int _BattlefieldSkillUsedCount;

		private int _SupportSkillUsedCount;

		private InnerCrossGuildContextProto _CrossGuildContext;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "LeftJoinColCount", DataFormat = DataFormat.TwosComplement)]
		public int LeftJoinColCount
		{
			get => _LeftJoinColCount;
			set => _LeftJoinColCount = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RightJoinColCount", DataFormat = DataFormat.TwosComplement)]
		public int RightJoinColCount
		{
			get => _RightJoinColCount;
			set => _RightJoinColCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "TotalBoutCount", DataFormat = DataFormat.TwosComplement)]
		public int TotalBoutCount
		{
			get => _TotalBoutCount;
			set => _TotalBoutCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "LeftDeadedHerosCount", DataFormat = DataFormat.TwosComplement)]
		public int LeftDeadedHerosCount
		{
			get => _LeftDeadedHerosCount;
			set => _LeftDeadedHerosCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "BattlefieldSkillUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int BattlefieldSkillUsedCount
		{
			get => _BattlefieldSkillUsedCount;
			set => _BattlefieldSkillUsedCount = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "SupportSkillUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int SupportSkillUsedCount
		{
			get => _SupportSkillUsedCount;
			set => _SupportSkillUsedCount = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "CrossGuildContext", DataFormat = DataFormat.Default)]
		public InnerCrossGuildContextProto CrossGuildContext
		{
			get => _CrossGuildContext;
			set => _CrossGuildContext = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
