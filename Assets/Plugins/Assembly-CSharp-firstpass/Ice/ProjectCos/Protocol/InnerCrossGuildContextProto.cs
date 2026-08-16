using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "InnerCrossGuildContextProto")]
	public class InnerCrossGuildContextProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "DeadInfoPorto")]
		public class DeadInfoPorto : IExtensible
		{
			private bool _IsLeftDead;

			private ulong _DeadPlayerId;

			private ulong _KillerId;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "IsLeftDead", DataFormat = DataFormat.Default)]
			public bool IsLeftDead
			{
				get => _IsLeftDead;
				set => _IsLeftDead = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "DeadPlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong DeadPlayerId
			{
				get => _DeadPlayerId;
				set => _DeadPlayerId = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "KillerId", DataFormat = DataFormat.TwosComplement)]
			public ulong KillerId
			{
				get => _KillerId;
				set => _KillerId = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "KillInfoProto")]
		public class KillInfoProto : IExtensible
		{
			private bool _IsLeft;

			private ulong _PlayerId;

			private int _KillHeroCount;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "IsLeft", DataFormat = DataFormat.Default)]
			public bool IsLeft
			{
				get => _IsLeft;
				set => _IsLeft = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong PlayerId
			{
				get => _PlayerId;
				set => _PlayerId = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "KillHeroCount", DataFormat = DataFormat.TwosComplement)]
			public int KillHeroCount
			{
				get => _KillHeroCount;
				set => _KillHeroCount = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<DeadInfoPorto> _DeadInfos;

		private List<KillInfoProto> _KillInfos;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "DeadInfos", DataFormat = DataFormat.Default)]
		public List<DeadInfoPorto> DeadInfos

		{

			get => _DeadInfos;

			set => _DeadInfos = value;

		}

		[ProtoMember(2, Name = "KillInfos", DataFormat = DataFormat.Default)]
		public List<KillInfoProto> KillInfos

		{

			get => _KillInfos;

			set => _KillInfos = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
