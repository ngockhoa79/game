using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortWrestRecordProto")]
	public class EscortWrestRecordProto : IExtensible
	{
		private PlayerSummaryInfoProto _Summary;

		private bool _Success;

		private int _Gold;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto Summary
		{
			get => _Summary;
			set => _Summary = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Success", DataFormat = DataFormat.Default)]
		public bool Success
		{
			get => _Success;
			set => _Success = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get => _Gold;
			set => _Gold = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
