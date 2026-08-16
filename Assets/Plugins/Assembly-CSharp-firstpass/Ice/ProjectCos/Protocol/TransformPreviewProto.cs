using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TransformPreviewProto")]
	public class TransformPreviewProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "HeroTransformItem")]
		public class HeroTransformItem : IExtensible
		{
			private int _Id;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _Gold;

		private int _Soul;

		private int _HeroNurturePellet;

		private int _RefineStone;

		private List<HeroTransformItem> _HeroExps;

		private List<HeroTransformItem> _HeroChips;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get => _Gold;
			set => _Gold = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Soul", DataFormat = DataFormat.TwosComplement)]
		public int Soul
		{
			get => _Soul;
			set => _Soul = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "HeroNurturePellet", DataFormat = DataFormat.TwosComplement)]
		public int HeroNurturePellet
		{
			get => _HeroNurturePellet;
			set => _HeroNurturePellet = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "RefineStone", DataFormat = DataFormat.TwosComplement)]
		public int RefineStone
		{
			get => _RefineStone;
			set => _RefineStone = value;
		}

		[ProtoMember(5, Name = "HeroExps", DataFormat = DataFormat.Default)]
		public List<HeroTransformItem> HeroExps

		{

			get => _HeroExps;

			set => _HeroExps = value;

		}

		[ProtoMember(6, Name = "HeroChips", DataFormat = DataFormat.Default)]
		public List<HeroTransformItem> HeroChips

		{

			get => _HeroChips;

			set => _HeroChips = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
