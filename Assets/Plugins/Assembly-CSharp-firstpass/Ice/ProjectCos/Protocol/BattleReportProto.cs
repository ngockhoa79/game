using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BattleReportProto")]
	public class BattleReportProto : IExtensible
	{
		private BattleFormationProto _LeftFormation;

		private BattleFormationProto _RightFormation;

		private List<BattleRoundProto> _Rounds;

		private bool _WinnerIsLeft;

		private string _UniqueSign;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "LeftFormation", DataFormat = DataFormat.Default)]
		public BattleFormationProto LeftFormation
		{
			get => _LeftFormation;
			set => _LeftFormation = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RightFormation", DataFormat = DataFormat.Default)]
		public BattleFormationProto RightFormation
		{
			get => _RightFormation;
			set => _RightFormation = value;
		}

		[ProtoMember(3, Name = "Rounds", DataFormat = DataFormat.Default)]
		public List<BattleRoundProto> Rounds

		{

			get => _Rounds;

			set => _Rounds = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "WinnerIsLeft", DataFormat = DataFormat.Default)]
		public bool WinnerIsLeft
		{
			get => _WinnerIsLeft;
			set => _WinnerIsLeft = value;
		}

		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "UniqueSign", DataFormat = DataFormat.Default)]
		public string UniqueSign
		{
			get => _UniqueSign;
			set => _UniqueSign = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
