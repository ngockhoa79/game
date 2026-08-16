using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GroupRemainAddHpProto")]
	public class GroupRemainAddHpProto : IExtensible
	{
		private List<PropertyChangeProto> _Changes;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<PropertyChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
