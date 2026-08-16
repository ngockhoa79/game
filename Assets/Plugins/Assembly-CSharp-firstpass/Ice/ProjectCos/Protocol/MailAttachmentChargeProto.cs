using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "MailAttachmentChargeProto")]
	public class MailAttachmentChargeProto : IExtensible
	{
		private int _Id;

		private int _Crystal;

		private int _ChargeCrystal;

		private bool _IsFirstCharge;

		private string _Channel;

		private string _OrderId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get => _Crystal;
			set => _Crystal = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ChargeCrystal", DataFormat = DataFormat.TwosComplement)]
		public int ChargeCrystal
		{
			get => _ChargeCrystal;
			set => _ChargeCrystal = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsFirstCharge", DataFormat = DataFormat.Default)]
		public bool IsFirstCharge
		{
			get => _IsFirstCharge;
			set => _IsFirstCharge = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Channel", DataFormat = DataFormat.Default)]
		public string Channel
		{
			get => _Channel;
			set => _Channel = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "OrderId", DataFormat = DataFormat.Default)]
		public string OrderId
		{
			get => _OrderId;
			set => _OrderId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
