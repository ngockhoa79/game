using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ActivityChapterProto")]
	public class ActivityChapterProto : IExtensible
	{
		private int _ChapterId;

		private int _CurDuplicateIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get => _ChapterId;
			set => _ChapterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CurDuplicateIndex", DataFormat = DataFormat.TwosComplement)]
		public int CurDuplicateIndex
		{
			get => _CurDuplicateIndex;
			set => _CurDuplicateIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
