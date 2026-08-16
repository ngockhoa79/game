using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FriendNoticeProto")]
	public class FriendNoticeProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "AddFriendNopticeProto")]
		public class AddFriendNopticeProto : IExtensible
		{
			private PlayerSummaryInfoProto _Summary;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Summary
			{
				get => _Summary;
				set => _Summary = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "LeaveMessageNoticeProto")]
		public class LeaveMessageNoticeProto : IExtensible
		{
			private PlayerSummaryInfoProto _Summary;

			private string _Message;

			private long _Time;

			private bool _IsSend;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Summary
			{
				get => _Summary;
				set => _Summary = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Message", DataFormat = DataFormat.Default)]
			public string Message
			{
				get => _Message;
				set => _Message = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "IsSend", DataFormat = DataFormat.Default)]
			public bool IsSend
			{
				get => _IsSend;
				set => _IsSend = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "TypeCode")]
		public enum TypeCode
		{
			[ProtoEnum(Name = "AddFriendReq", Value = 0)]
			AddFriendReq = 0,
			[ProtoEnum(Name = "LeaveMessage", Value = 1)]
			LeaveMessage = 1
		}

		private TypeCode _Code;

		private AddFriendNopticeProto _AddFriendNoticeInfo;

		private LeaveMessageNoticeProto _LeaveMessageNoticeInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public TypeCode Code
		{
			get
			{
				return default(TypeCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "AddFriendNoticeInfo", DataFormat = DataFormat.Default)]
		public AddFriendNopticeProto AddFriendNoticeInfo
		{
			get => _AddFriendNoticeInfo;
			set => _AddFriendNoticeInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "LeaveMessageNoticeInfo", DataFormat = DataFormat.Default)]
		public LeaveMessageNoticeProto LeaveMessageNoticeInfo
		{
			get => _LeaveMessageNoticeInfo;
			set => _LeaveMessageNoticeInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
