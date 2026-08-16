using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SCrossGuildBattleReportDetailReq")]
	public class C2SCrossGuildBattleReportDetailReq : IExtensible
	{
		private int _LineIndex;

		private bool _IsFirstRound;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "LineIndex", DataFormat = DataFormat.TwosComplement)]
		public int LineIndex
		{
			get => _LineIndex;
			set => _LineIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsFirstRound", DataFormat = DataFormat.Default)]
		public bool IsFirstRound
		{
			get => _IsFirstRound;
			set => _IsFirstRound = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
