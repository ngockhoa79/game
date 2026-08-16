using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ExpensePickProto")]
	public class ExpensePickProto : IExtensible
	{
		private int _IndexMark;

		private List<ItemChangeProto> _Changes;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IndexMark", DataFormat = DataFormat.TwosComplement)]
		public int IndexMark
		{
			get => _IndexMark;
			set => _IndexMark = value;
		}

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

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
