using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "MailItemProto")]
	public class MailItemProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "System", Value = 1)]
			System = 1,
			[ProtoEnum(Name = "Battle", Value = 2)]
			Battle = 2
		}

		private int _MailId;

		private TypeEnum _Type;

		private int _OrderId;

		private string _Title;

		private string _Content;

		private long _Time;

		private bool _IsReaded;

		private bool _IsPicked;

		private List<MaillAttachmentItemProto> _Attachments;

		private int _Expires;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MailId", DataFormat = DataFormat.TwosComplement)]
		public int MailId
		{
			get => _MailId;
			set => _MailId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
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

		[ProtoMember(3, IsRequired = true, Name = "OrderId", DataFormat = DataFormat.TwosComplement)]
		public int OrderId
		{
			get => _OrderId;
			set => _OrderId = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get => _Title;
			set => _Title = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get => _Content;
			set => _Content = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public long Time
		{
			get => _Time;
			set => _Time = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "IsReaded", DataFormat = DataFormat.Default)]
		public bool IsReaded
		{
			get => _IsReaded;
			set => _IsReaded = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "IsPicked", DataFormat = DataFormat.Default)]
		public bool IsPicked
		{
			get => _IsPicked;
			set => _IsPicked = value;
		}

		[ProtoMember(10, Name = "Attachments", DataFormat = DataFormat.Default)]
		public List<MaillAttachmentItemProto> Attachments

		{

			get => _Attachments;

			set => _Attachments = value;

		}

		[ProtoMember(11, IsRequired = true, Name = "Expires", DataFormat = DataFormat.TwosComplement)]
		public int Expires
		{
			get => _Expires;
			set => _Expires = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
