using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CChatNtf")]
	public class S2CChatNtf : IExtensible
	{
		private PlayerSummaryInfoProto _Sender;

		private C2SChatReq.TypeEnum _Type;

		private string _Message;

		private long _Time;

		private ulong _Id;

		private GuildMemberInfoProto.TypeEnum _GuildPostion;

		private bool _IsGuildInvite;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Sender", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto Sender
		{
			get => _Sender;
			set => _Sender = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SChatReq.TypeEnum Type
		{
			get
			{
				return default(C2SChatReq.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "Message", DataFormat = DataFormat.Default)]
		public string Message
		{
			get => _Message;
			set => _Message = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public long Time
		{
			get => _Time;
			set => _Time = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public ulong Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "GuildPostion", DataFormat = DataFormat.TwosComplement)]
		public GuildMemberInfoProto.TypeEnum GuildPostion
		{
			get
			{
				return default(GuildMemberInfoProto.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(8, IsRequired = true, Name = "IsGuildInvite", DataFormat = DataFormat.Default)]
		public bool IsGuildInvite
		{
			get => _IsGuildInvite;
			set => _IsGuildInvite = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
