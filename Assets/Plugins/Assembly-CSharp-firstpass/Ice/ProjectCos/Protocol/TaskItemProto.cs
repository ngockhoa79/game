using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TaskItemProto")]
	public class TaskItemProto : IExtensible
	{
		private int _Id;

		private int _CurrentValue;

		private int _FinishValue;

		private bool _IsAlreadyPick;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CurrentValue", DataFormat = DataFormat.TwosComplement)]
		public int CurrentValue
		{
			get => _CurrentValue;
			set => _CurrentValue = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "FinishValue", DataFormat = DataFormat.TwosComplement)]
		public int FinishValue
		{
			get => _FinishValue;
			set => _FinishValue = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsAlreadyPick", DataFormat = DataFormat.Default)]
		public bool IsAlreadyPick
		{
			get => _IsAlreadyPick;
			set => _IsAlreadyPick = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
