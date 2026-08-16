using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortCompleteInfoProto")]
	public class EscortCompleteInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ComplteteInfoProto")]
		public class ComplteteInfoProto : IExtensible
		{
			private int _CarId;

			private int _RemainGold;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
			public int CarId
			{
				get => _CarId;
				set => _CarId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "RemainGold", DataFormat = DataFormat.TwosComplement)]
			public int RemainGold
			{
				get => _RemainGold;
				set => _RemainGold = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "BeWrestInfoProto")]
		public class BeWrestInfoProto : IExtensible
		{
			private int _CarId;

			private PlayerSummaryInfoProto _RobberSummaryInfo;

			private int _AlreayGetReward;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
			public int CarId
			{
				get => _CarId;
				set => _CarId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "RobberSummaryInfo", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto RobberSummaryInfo
			{
				get => _RobberSummaryInfo;
				set => _RobberSummaryInfo = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "AlreayGetReward", DataFormat = DataFormat.TwosComplement)]
			public int AlreayGetReward
			{
				get => _AlreayGetReward;
				set => _AlreayGetReward = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "StatusCode")]
		public enum StatusCode
		{
			[ProtoEnum(Name = "Complete", Value = 1)]
			Complete = 1,
			[ProtoEnum(Name = "BeWrest", Value = 2)]
			BeWrest = 2
		}

		private StatusCode _Status;

		private ComplteteInfoProto _CompleteInfo;

		private BeWrestInfoProto _BeWrestInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public StatusCode Status
		{
			get
			{
				return default(StatusCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "CompleteInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ComplteteInfoProto CompleteInfo
		{
			get => _CompleteInfo;
			set => _CompleteInfo = value;
		}

		[ProtoMember(3, IsRequired = false, Name = "BeWrestInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public BeWrestInfoProto BeWrestInfo
		{
			get => _BeWrestInfo;
			set => _BeWrestInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
