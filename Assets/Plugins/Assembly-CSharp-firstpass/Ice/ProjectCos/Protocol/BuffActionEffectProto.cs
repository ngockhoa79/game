using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BuffActionEffectProto")]
	public class BuffActionEffectProto : IExtensible
	{
		private int _ActionIndex;

		private int _BuffId;

		private int _BuffUniqueId;

		private List<PropertyChangeProto> _Propertys;

		private bool _IsImmune;

		private int _AttachId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ActionIndex", DataFormat = DataFormat.TwosComplement)]
		public int ActionIndex
		{
			get => _ActionIndex;
			set => _ActionIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BuffId", DataFormat = DataFormat.TwosComplement)]
		public int BuffId
		{
			get => _BuffId;
			set => _BuffId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuffUniqueId", DataFormat = DataFormat.TwosComplement)]
		public int BuffUniqueId
		{
			get => _BuffUniqueId;
			set => _BuffUniqueId = value;
		}

		[ProtoMember(4, Name = "Propertys", DataFormat = DataFormat.Default)]
		public List<PropertyChangeProto> Propertys

		{

			get => _Propertys;

			set => _Propertys = value;

		}

		[ProtoMember(5, IsRequired = true, Name = "IsImmune", DataFormat = DataFormat.Default)]
		public bool IsImmune
		{
			get => _IsImmune;
			set => _IsImmune = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "AttachId", DataFormat = DataFormat.TwosComplement)]
		public int AttachId
		{
			get => _AttachId;
			set => _AttachId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
