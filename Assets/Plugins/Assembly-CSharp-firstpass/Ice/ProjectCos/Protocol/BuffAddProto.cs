using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BuffAddProto")]
	public class BuffAddProto : IExtensible
	{
		private int _SourceFighterId;

		private int _TargetFighterId;

		private int _BuffId;

		private int _BuffUniqueId;

		private List<BuffActionEffectProto> _DirectActionEffects;

		private bool _IsImmune;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SourceFighterId", DataFormat = DataFormat.TwosComplement)]
		public int SourceFighterId
		{
			get => _SourceFighterId;
			set => _SourceFighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int TargetFighterId
		{
			get => _TargetFighterId;
			set => _TargetFighterId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuffId", DataFormat = DataFormat.TwosComplement)]
		public int BuffId
		{
			get => _BuffId;
			set => _BuffId = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "BuffUniqueId", DataFormat = DataFormat.TwosComplement)]
		public int BuffUniqueId
		{
			get => _BuffUniqueId;
			set => _BuffUniqueId = value;
		}

		[ProtoMember(5, Name = "DirectActionEffects", DataFormat = DataFormat.Default)]
		public List<BuffActionEffectProto> DirectActionEffects

		{

			get => _DirectActionEffects;

			set => _DirectActionEffects = value;

		}

		[ProtoMember(6, IsRequired = true, Name = "IsImmune", DataFormat = DataFormat.Default)]
		public bool IsImmune
		{
			get => _IsImmune;
			set => _IsImmune = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
