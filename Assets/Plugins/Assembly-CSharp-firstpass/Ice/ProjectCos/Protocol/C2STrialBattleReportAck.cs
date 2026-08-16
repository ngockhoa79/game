using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2STrialBattleReportAck")]
	public class C2STrialBattleReportAck : IExtensible
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

		private TrialBattleReporProto _Reports;

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

		[ProtoMember(2, IsRequired = true, Name = "Reports", DataFormat = DataFormat.Default)]
		public TrialBattleReporProto Reports
		{
			get => _Reports;
			set => _Reports = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
