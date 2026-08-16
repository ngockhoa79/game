using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildSummaryInfoProto")]
	public class GuildSummaryInfoProto : IExtensible
	{
		private GuildInfoProto _BaseInfo;

		private string _PresidentName;

		private int _Ranking;

		private bool _IsApplication;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto BaseInfo
		{
			get => _BaseInfo;
			set => _BaseInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "PresidentName", DataFormat = DataFormat.Default)]
		public string PresidentName
		{
			get => _PresidentName;
			set => _PresidentName = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsApplication", DataFormat = DataFormat.Default)]
		public bool IsApplication
		{
			get => _IsApplication;
			set => _IsApplication = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
