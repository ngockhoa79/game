using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildPartyInfoProto")]
	public class GuildPartyInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "PartyRecordProto")]
		public class PartyRecordProto : IExtensible
		{
			private GuildMemberInfoProto.TypeEnum _Type;

			private string _Name;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
			public GuildMemberInfoProto.TypeEnum Type
			{
				get
				{
					return default(GuildMemberInfoProto.TypeEnum);
				}
				set
				{
				}
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _PartyId;

		private List<PartyRecordProto> _Records;

		private int _Count;

		private int _Total;

		private bool _IsPartyPickAlready;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PartyId", DataFormat = DataFormat.TwosComplement)]
		public int PartyId
		{
			get => _PartyId;
			set => _PartyId = value;
		}

		[ProtoMember(2, Name = "Records", DataFormat = DataFormat.Default)]
		public List<PartyRecordProto> Records

		{

			get => _Records;

			set => _Records = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Total", DataFormat = DataFormat.TwosComplement)]
		public int Total
		{
			get => _Total;
			set => _Total = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "IsPartyPickAlready", DataFormat = DataFormat.Default)]
		public bool IsPartyPickAlready
		{
			get => _IsPartyPickAlready;
			set => _IsPartyPickAlready = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
