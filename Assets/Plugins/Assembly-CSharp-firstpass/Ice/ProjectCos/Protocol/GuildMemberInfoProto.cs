using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildMemberInfoProto")]
	public class GuildMemberInfoProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "Member", Value = 1)]
			Member = 1,
			[ProtoEnum(Name = "VicePresident", Value = 2)]
			VicePresident = 2,
			[ProtoEnum(Name = "President", Value = 3)]
			President = 3
		}

		private PlayerSummaryInfoProto _SummaryInfo;

		private int _Contributiont;

		private TypeEnum _Type;

		private bool _IsDailyDonated;

		private long _DemoteEnableTime;

		private bool _IsOnline;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Contributiont", DataFormat = DataFormat.TwosComplement)]
		public int Contributiont
		{
			get => _Contributiont;
			set => _Contributiont = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "IsDailyDonated", DataFormat = DataFormat.Default)]
		public bool IsDailyDonated
		{
			get => _IsDailyDonated;
			set => _IsDailyDonated = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "DemoteEnableTime", DataFormat = DataFormat.TwosComplement)]
		public long DemoteEnableTime
		{
			get => _DemoteEnableTime;
			set => _DemoteEnableTime = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "IsOnline", DataFormat = DataFormat.Default)]
		public bool IsOnline
		{
			get => _IsOnline;
			set => _IsOnline = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
