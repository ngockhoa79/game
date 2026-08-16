using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "HarmInfoProto")]
	public class HarmInfoProto : IExtensible
	{
		[ProtoContract(Name = "AgainstType")]
		public enum AgainstType
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "Anti", Value = 1)]
			Anti = 1,
			[ProtoEnum(Name = "Weak", Value = 2)]
			Weak = 2
		}

		private int _SourceFighterId;

		private int _TargetFighterId;

		private bool _IsHit;

		private bool _IsCrit;

		private bool _IsBlock;

		private int _HarmValue;

		private int _BlockHarmValue;

		private AgainstType _Against;

		private bool _IsSourceDead;

		private bool _IsTargetDead;

		private bool _IsSourceImmune;

		private bool _IsTargetImmune;

		private int _AfterHp;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SourceFighterId", DataFormat = DataFormat.TwosComplement)]
		public int SourceFighterId
		{
			get => _SourceFighterId;
			set => _SourceFighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int TargetFighterId
		{
			get => _TargetFighterId;
			set => _TargetFighterId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsHit", DataFormat = DataFormat.Default)]
		public bool IsHit
		{
			get => _IsHit;
			set => _IsHit = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsCrit", DataFormat = DataFormat.Default)]
		public bool IsCrit
		{
			get => _IsCrit;
			set => _IsCrit = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "IsBlock", DataFormat = DataFormat.Default)]
		public bool IsBlock
		{
			get => _IsBlock;
			set => _IsBlock = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "HarmValue", DataFormat = DataFormat.TwosComplement)]
		public int HarmValue
		{
			get => _HarmValue;
			set => _HarmValue = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "BlockHarmValue", DataFormat = DataFormat.TwosComplement)]
		public int BlockHarmValue
		{
			get => _BlockHarmValue;
			set => _BlockHarmValue = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "Against", DataFormat = DataFormat.TwosComplement)]
		public AgainstType Against
		{
			get
			{
				return default(AgainstType);
			}
			set
			{
			}
		}

		[ProtoMember(9, IsRequired = true, Name = "IsSourceDead", DataFormat = DataFormat.Default)]
		public bool IsSourceDead
		{
			get => _IsSourceDead;
			set => _IsSourceDead = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "IsTargetDead", DataFormat = DataFormat.Default)]
		public bool IsTargetDead
		{
			get => _IsTargetDead;
			set => _IsTargetDead = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "IsSourceImmune", DataFormat = DataFormat.Default)]
		public bool IsSourceImmune
		{
			get => _IsSourceImmune;
			set => _IsSourceImmune = value;
		}

		[ProtoMember(12, IsRequired = true, Name = "IsTargetImmune", DataFormat = DataFormat.Default)]
		public bool IsTargetImmune
		{
			get => _IsTargetImmune;
			set => _IsTargetImmune = value;
		}

		[ProtoMember(13, IsRequired = true, Name = "AfterHp", DataFormat = DataFormat.TwosComplement)]
		public int AfterHp
		{
			get => _AfterHp;
			set => _AfterHp = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
