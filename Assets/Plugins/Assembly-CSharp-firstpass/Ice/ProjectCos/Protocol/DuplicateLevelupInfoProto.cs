using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateLevelupInfoProto")]
	public class DuplicateLevelupInfoProto : IExtensible
	{
		private int _Level;

		private string _ExpPercentage;

		private int _Energy;

		private int _EnergyMax;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ExpPercentage", DataFormat = DataFormat.Default)]
		public string ExpPercentage
		{
			get => _ExpPercentage;
			set => _ExpPercentage = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Energy", DataFormat = DataFormat.TwosComplement)]
		public int Energy
		{
			get => _Energy;
			set => _Energy = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "EnergyMax", DataFormat = DataFormat.TwosComplement)]
		public int EnergyMax
		{
			get => _EnergyMax;
			set => _EnergyMax = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
