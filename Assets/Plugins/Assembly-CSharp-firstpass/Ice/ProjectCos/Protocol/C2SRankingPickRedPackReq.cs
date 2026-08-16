using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRankingPickRedPackReq")]
	public class C2SRankingPickRedPackReq : IExtensible
	{
		private int _RedPackId;

		private C2SRedPackListReq.TypeEnum _Type;

		private bool _IsCorrect;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RedPackId", DataFormat = DataFormat.TwosComplement)]
		public int RedPackId
		{
			get => _RedPackId;
			set => _RedPackId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SRedPackListReq.TypeEnum Type
		{
			get
			{
				return default(C2SRedPackListReq.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "IsCorrect", DataFormat = DataFormat.Default)]
		public bool IsCorrect
		{
			get => _IsCorrect;
			set => _IsCorrect = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
