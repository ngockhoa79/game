using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildDonateInfoProto")]
	public class GuildDonateInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "DonateRecordProto")]
		public class DonateRecordProto : IExtensible
		{
			private int _Id;

			private string _Name;

			private GuildMemberInfoProto.TypeEnum _Postion;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Postion", DataFormat = DataFormat.TwosComplement)]
			public GuildMemberInfoProto.TypeEnum Postion
			{
				get
				{
					return default(GuildMemberInfoProto.TypeEnum);
				}
				set
				{
				}
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _DonateMark;

		private List<DonateRecordProto> _Records;

		private int _Count;

		private int _Total;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DonateMark", DataFormat = DataFormat.TwosComplement)]
		public int DonateMark
		{
			get => _DonateMark;
			set => _DonateMark = value;
		}

		[ProtoMember(2, Name = "Records", DataFormat = DataFormat.Default)]
		public List<DonateRecordProto> Records

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
