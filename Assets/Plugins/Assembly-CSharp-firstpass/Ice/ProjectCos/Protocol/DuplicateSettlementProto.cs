using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateSettlementProto")]
	public class DuplicateSettlementProto : IExtensible
	{
		private int _DuplicateId;

		private List<DuplicateDropProto> _Drop;

		private int _GoldAdd;

		private int _ExpAdd;

		private int _FriendshipAdd;

		private int _EnergySub;

		private int _Star;

		private int _CurLevel;

		private string _CurExpPercentage;

		private DuplicateLevelupInfoProto _LevelupInfo;

		private bool _IsTaskFirstFinish;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		[ProtoMember(2, Name = "Drop", DataFormat = DataFormat.Default)]
		public List<DuplicateDropProto> Drop

		{

			get => _Drop;

			set => _Drop = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "GoldAdd", DataFormat = DataFormat.TwosComplement)]
		public int GoldAdd
		{
			get => _GoldAdd;
			set => _GoldAdd = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ExpAdd", DataFormat = DataFormat.TwosComplement)]
		public int ExpAdd
		{
			get => _ExpAdd;
			set => _ExpAdd = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "FriendshipAdd", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipAdd
		{
			get => _FriendshipAdd;
			set => _FriendshipAdd = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "EnergySub", DataFormat = DataFormat.TwosComplement)]
		public int EnergySub
		{
			get => _EnergySub;
			set => _EnergySub = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Star", DataFormat = DataFormat.TwosComplement)]
		public int Star
		{
			get => _Star;
			set => _Star = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "CurLevel", DataFormat = DataFormat.TwosComplement)]
		public int CurLevel
		{
			get => _CurLevel;
			set => _CurLevel = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "CurExpPercentage", DataFormat = DataFormat.Default)]
		public string CurExpPercentage
		{
			get => _CurExpPercentage;
			set => _CurExpPercentage = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "LevelupInfo", DataFormat = DataFormat.Default)]
		public DuplicateLevelupInfoProto LevelupInfo
		{
			get => _LevelupInfo;
			set => _LevelupInfo = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "IsTaskFirstFinish", DataFormat = DataFormat.Default)]
		public bool IsTaskFirstFinish
		{
			get => _IsTaskFirstFinish;
			set => _IsTaskFirstFinish = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
