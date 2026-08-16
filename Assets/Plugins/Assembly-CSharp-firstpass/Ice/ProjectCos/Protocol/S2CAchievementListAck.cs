using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CAchievementListAck")]
	public class S2CAchievementListAck : IExtensible
	{
		private List<AchievementGroupProto> _Groups;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Groups", DataFormat = DataFormat.Default)]
		public List<AchievementGroupProto> Groups

		{

			get => _Groups;

			set => _Groups = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
