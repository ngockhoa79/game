using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPlayerSummaryInfoProto")]
	public class CrossPlayerSummaryInfoProto : IExtensible
	{
		private int _ReamNum;

		private PlayerSummaryInfoProto _SummaryInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ReamNum", DataFormat = DataFormat.TwosComplement)]
		public int ReamNum
		{
			get => _ReamNum;
			set => _ReamNum = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
