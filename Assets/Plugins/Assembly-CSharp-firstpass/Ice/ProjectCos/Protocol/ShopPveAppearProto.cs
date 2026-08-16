using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ShopPveAppearProto")]
	public class ShopPveAppearProto : IExtensible
	{
		private long _OverTime;

		private bool _IsOpen1;

		private bool _IsOpen2;

		private bool _IsOpen3;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
		public long OverTime
		{
			get => _OverTime;
			set => _OverTime = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsOpen1", DataFormat = DataFormat.Default)]
		public bool IsOpen1
		{
			get => _IsOpen1;
			set => _IsOpen1 = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsOpen2", DataFormat = DataFormat.Default)]
		public bool IsOpen2
		{
			get => _IsOpen2;
			set => _IsOpen2 = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsOpen3", DataFormat = DataFormat.Default)]
		public bool IsOpen3
		{
			get => _IsOpen3;
			set => _IsOpen3 = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
