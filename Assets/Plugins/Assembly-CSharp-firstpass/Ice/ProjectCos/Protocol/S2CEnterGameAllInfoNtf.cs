using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEnterGameAllInfoNtf")]
	public class S2CEnterGameAllInfoNtf : IExtensible
	{
		private PlayerAllInfoProto _PlayerAllInfo;
		private int _TimeZoneRawOffset;
		private long _UnixTimestamp;
		private string _PayGssToken;
		private SettingProto _SettingInfo;
		private bool _IsShowVip;
		private bool _IsAppStorePay;
		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerAllInfo", DataFormat = DataFormat.Default)]
		public PlayerAllInfoProto PlayerAllInfo
		{
			get => _PlayerAllInfo;
			set => _PlayerAllInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TimeZoneRawOffset", DataFormat = DataFormat.TwosComplement)]
		public int TimeZoneRawOffset
		{
			get => _TimeZoneRawOffset;
			set => _TimeZoneRawOffset = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "UnixTimestamp", DataFormat = DataFormat.TwosComplement)]
		public long UnixTimestamp
		{
			get => _UnixTimestamp;
			set => _UnixTimestamp = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "PayGssToken", DataFormat = DataFormat.Default)]
		public string PayGssToken
		{
			get => _PayGssToken;
			set => _PayGssToken = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "SettingInfo", DataFormat = DataFormat.Default)]
		public SettingProto SettingInfo
		{
			get => _SettingInfo;
			set => _SettingInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "IsShowVip", DataFormat = DataFormat.Default)]
		public bool IsShowVip
		{
			get => _IsShowVip;
			set => _IsShowVip = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "IsAppStorePay", DataFormat = DataFormat.Default)]
		public bool IsAppStorePay
		{
			get => _IsAppStorePay;
			set => _IsAppStorePay = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
