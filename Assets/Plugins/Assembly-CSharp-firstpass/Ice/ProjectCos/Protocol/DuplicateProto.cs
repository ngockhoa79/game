using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateProto")]
	public class DuplicateProto : IExtensible
	{
		private int _DuplicateId;

		private int _Star;

		private bool _IsTaskFirstFinish;

		private bool _IsTaskPickAlready;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Star", DataFormat = DataFormat.TwosComplement)]
		public int Star
		{
			get => _Star;
			set => _Star = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsTaskFirstFinish", DataFormat = DataFormat.Default)]
		public bool IsTaskFirstFinish
		{
			get => _IsTaskFirstFinish;
			set => _IsTaskFirstFinish = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsTaskPickAlready", DataFormat = DataFormat.Default)]
		public bool IsTaskPickAlready
		{
			get => _IsTaskPickAlready;
			set => _IsTaskPickAlready = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
