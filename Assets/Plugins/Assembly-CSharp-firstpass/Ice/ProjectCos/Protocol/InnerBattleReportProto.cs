using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "InnerBattleReportProto")]
	public class InnerBattleReportProto : IExtensible
	{
		private BattleReportProto _ReportProto;

		private InnerBattleContextProto _Context;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ReportProto", DataFormat = DataFormat.Default)]
		public BattleReportProto ReportProto
		{
			get => _ReportProto;
			set => _ReportProto = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Context", DataFormat = DataFormat.Default)]
		public InnerBattleContextProto Context
		{
			get => _Context;
			set => _Context = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
