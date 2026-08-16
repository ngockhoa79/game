using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialInfoProto")]
	public class TrialInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "SuperStageProto")]
		public class SuperStageProto : IExtensible
		{
			private int _StageIndex;

			private bool _IsEnableReward;

			private TrialForamtionProto _Formation;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "StageIndex", DataFormat = DataFormat.TwosComplement)]
			public int StageIndex
			{
				get => _StageIndex;
				set => _StageIndex = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "IsEnableReward", DataFormat = DataFormat.Default)]
			public bool IsEnableReward
			{
				get => _IsEnableReward;
				set => _IsEnableReward = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
			public TrialForamtionProto Formation
			{
				get => _Formation;
				set => _Formation = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _TrialCoin;

		private int _StageIndex;

		private TrialForamtionProto _Stage;

		private List<SuperStageProto> _SuperStages;

		private List<TrialForamtionProto> _Friends;

		private List<TrialForamtionProto> _Strangers;

		private bool _IsStageEnableReward;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TrialCoin", DataFormat = DataFormat.TwosComplement)]
		public int TrialCoin
		{
			get => _TrialCoin;
			set => _TrialCoin = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "StageIndex", DataFormat = DataFormat.TwosComplement)]
		public int StageIndex
		{
			get => _StageIndex;
			set => _StageIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Stage", DataFormat = DataFormat.Default)]
		public TrialForamtionProto Stage
		{
			get => _Stage;
			set => _Stage = value;
		}

		[ProtoMember(4, Name = "SuperStages", DataFormat = DataFormat.Default)]
		public List<SuperStageProto> SuperStages

		{

			get => _SuperStages;

			set => _SuperStages = value;

		}

		[ProtoMember(5, Name = "Friends", DataFormat = DataFormat.Default)]
		public List<TrialForamtionProto> Friends

		{

			get => _Friends;

			set => _Friends = value;

		}

		[ProtoMember(6, Name = "Strangers", DataFormat = DataFormat.Default)]
		public List<TrialForamtionProto> Strangers

		{

			get => _Strangers;

			set => _Strangers = value;

		}

		[ProtoMember(7, IsRequired = true, Name = "IsStageEnableReward", DataFormat = DataFormat.Default)]
		public bool IsStageEnableReward
		{
			get => _IsStageEnableReward;
			set => _IsStageEnableReward = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
