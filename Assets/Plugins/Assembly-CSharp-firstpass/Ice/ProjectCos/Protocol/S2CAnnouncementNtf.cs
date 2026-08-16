using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CAnnouncementNtf")]
	public class S2CAnnouncementNtf : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private int _arg1;

		private string _arg2;

		private AnnouncementItemProto _arg3;

		private string _arg4;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "arg1", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int Arg1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "arg2", DataFormat = DataFormat.Default)]
		public string Arg2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "arg3", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public AnnouncementItemProto Arg3
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "arg4", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public string Arg4
		{
			get
			{
				return null;
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
}
