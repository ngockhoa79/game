using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ChargeInfoProto")]
	public class ChargeInfoProto : IExtensible
	{
		private int _MonthDayReaminDay;

		private List<int> _FirstDoubleUsedInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MonthDayReaminDay", DataFormat = DataFormat.TwosComplement)]
		public int MonthDayReaminDay
		{
			get => _MonthDayReaminDay;
			set => _MonthDayReaminDay = value;
		}

		[ProtoMember(2, Name = "FirstDoubleUsedInfo", DataFormat = DataFormat.TwosComplement)]
		public List<int> FirstDoubleUsedInfo

		{

			get => _FirstDoubleUsedInfo;

			set => _FirstDoubleUsedInfo = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
