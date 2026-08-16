using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FinalCompetitionProto")]
	public class FinalCompetitionProto : IExtensible
	{
		private List<FinalCompetitionItemProro> _Items;

		private bool _WinnerIsLeft;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<FinalCompetitionItemProro> Items

		{

			get => _Items;

			set => _Items = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "WinnerIsLeft", DataFormat = DataFormat.Default)]
		public bool WinnerIsLeft
		{
			get => _WinnerIsLeft;
			set => _WinnerIsLeft = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
