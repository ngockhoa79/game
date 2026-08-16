using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SSkillStarLevelupReq")]
	public class C2SSkillStarLevelupReq : IExtensible
	{
		private int _TargetIndex;

		private List<int> _SacrificeIndexs;

		private List<int> _ReplacedStones;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TargetIndex", DataFormat = DataFormat.TwosComplement)]
		public int TargetIndex
		{
			get => _TargetIndex;
			set => _TargetIndex = value;
		}

		[ProtoMember(2, Name = "SacrificeIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> SacrificeIndexs

		{

			get => _SacrificeIndexs;

			set => _SacrificeIndexs = value;

		}

		[ProtoMember(3, Name = "ReplacedStones", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReplacedStones

		{

			get => _ReplacedStones;

			set => _ReplacedStones = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
