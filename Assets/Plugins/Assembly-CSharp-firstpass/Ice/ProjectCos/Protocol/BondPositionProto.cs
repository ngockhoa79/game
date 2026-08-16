using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PositionInfo")]
	public class BondPositionProto : IExtensible
	{
		private List<PositionInfo> _Positions;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Positions", DataFormat = DataFormat.Default)]
		public List<PositionInfo> Positions
		{
			get => _Positions;
			set => _Positions = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
