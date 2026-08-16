using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildInfoProto")]
	public class GuildInfoProto : IExtensible
	{
		private int _Id;

		private string _Name;

		private int _Icon;

		private int _Level;

		private int _Exp;

		private ulong _PresidentId;

		private string _Announcement;

		private int _MemberCount;

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

		[ProtoMember(3, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
		public int Icon
		{
			get => _Icon;
			set => _Icon = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
		public int Exp
		{
			get => _Exp;
			set => _Exp = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "PresidentId", DataFormat = DataFormat.TwosComplement)]
		public ulong PresidentId
		{
			get => _PresidentId;
			set => _PresidentId = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Announcement", DataFormat = DataFormat.Default)]
		public string Announcement
		{
			get => _Announcement;
			set => _Announcement = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "MemberCount", DataFormat = DataFormat.TwosComplement)]
		public int MemberCount
		{
			get => _MemberCount;
			set => _MemberCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
