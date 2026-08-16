using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "SettingProto")]
	public class SettingProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ValuePairProto")]
		public class ValuePairProto : IExtensible
		{
			private string _Key;

			private string _Value;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Key", DataFormat = DataFormat.Default)]
			public string Key
			{
				get => _Key;
				set => _Key = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
			public string Value
			{
				get => _Value;
				set => _Value = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "SettingEnum")]
		public enum SettingEnum
		{
			[ProtoEnum(Name = "ChatBarrage", Value = 0)]
			ChatBarrage = 0
		}

		private List<ValuePairProto> _Values;

		private int _SettingsMark;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Values", DataFormat = DataFormat.Default)]
		public List<ValuePairProto> Values

		{

			get => _Values;

			set => _Values = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "SettingsMark", DataFormat = DataFormat.TwosComplement)]
		public int SettingsMark
		{
			get => _SettingsMark;
			set => _SettingsMark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
