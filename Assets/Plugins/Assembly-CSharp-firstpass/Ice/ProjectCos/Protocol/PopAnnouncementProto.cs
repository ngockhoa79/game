using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PopAnnouncementProto")]
	public class PopAnnouncementProto : IExtensible
	{
		private string _Title;

		private string _Content;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get => _Title;
			set => _Title = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get => _Content;
			set => _Content = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
