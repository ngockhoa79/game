using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerGuildInfoProto")]
	public class PlayerGuildInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "BuffProto")]
		public class BuffProto : IExtensible
		{
			private int _BuffId;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "BuffId", DataFormat = DataFormat.TwosComplement)]
			public int BuffId
			{
				get => _BuffId;
				set => _BuffId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _CurBuffTreeIndex;

		private List<BuffProto> _Buffs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "CurBuffTreeIndex", DataFormat = DataFormat.TwosComplement)]
		public int CurBuffTreeIndex
		{
			get => _CurBuffTreeIndex;
			set => _CurBuffTreeIndex = value;
		}

		[ProtoMember(2, Name = "Buffs", DataFormat = DataFormat.Default)]
		public List<BuffProto> Buffs

		{

			get => _Buffs;

			set => _Buffs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
