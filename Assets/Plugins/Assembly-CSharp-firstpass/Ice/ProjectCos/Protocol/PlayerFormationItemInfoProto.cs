using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerFormationItemInfoProto")]
	public class PlayerFormationItemInfoProto : IExtensible
	{
		private List<int> _LeaderHeroIndexs;

		private List<int> _HerosIndexList;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "LeaderHeroIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> LeaderHeroIndexs

		{

			get => _LeaderHeroIndexs;

			set => _LeaderHeroIndexs = value;

		}

		[ProtoMember(2, Name = "HerosIndexList", DataFormat = DataFormat.TwosComplement)]
		public List<int> HerosIndexList

		{

			get => _HerosIndexList;

			set => _HerosIndexList = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
