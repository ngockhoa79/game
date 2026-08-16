using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "MailAttachmentBattleReportProto")]
	public class MailAttachmentBattleReportProto : IExtensible
	{
		private int _ReportId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ReportId", DataFormat = DataFormat.TwosComplement)]
		public int ReportId
		{
			get => _ReportId;
			set => _ReportId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
