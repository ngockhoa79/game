using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RobberyNoticeInfoListProto")]
	public class RobberyNoticeInfoListProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "FrinedInfo")]
		public class FrinedInfo : IExtensible
		{
			private PlayerSummaryInfoProto _Friend;

			private PlayerSummaryInfoProto _Targeter;

			private int _SkillChipId;

			private long _Time;

			private TypeEnum _Type;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Friend", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Friend
			{
				get => _Friend;
				set => _Friend = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Targeter", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Targeter
			{
				get => _Targeter;
				set => _Targeter = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "SkillChipId", DataFormat = DataFormat.TwosComplement)]
			public int SkillChipId
			{
				get => _SkillChipId;
				set => _SkillChipId = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
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

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Requested", Value = 0)]
			Requested = 0,
			[ProtoEnum(Name = "Feedback", Value = 1)]
			Feedback = 1,
			[ProtoEnum(Name = "FeedbackFail", Value = 2)]
			FeedbackFail = 2
		}

		private List<FrinedInfo> _Notices;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Notices", DataFormat = DataFormat.Default)]
		public List<FrinedInfo> Notices

		{

			get => _Notices;

			set => _Notices = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
