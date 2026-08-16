using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortTargetProto")]
	public class EscortTargetProto : IExtensible
	{
		private PlayerSummaryInfoProto _PlayerSummaryInfo;

		private EscortCarInfoProto _CarInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerSummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto PlayerSummaryInfo
		{
			get => _PlayerSummaryInfo;
			set => _PlayerSummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CarInfo", DataFormat = DataFormat.Default)]
		public EscortCarInfoProto CarInfo
		{
			get => _CarInfo;
			set => _CarInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
