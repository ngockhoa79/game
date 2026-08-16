using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SApplyCouponReq")]
	public class C2SApplyCouponReq : IExtensible
	{
		private string _Coupon;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Coupon", DataFormat = DataFormat.Default)]
		public string Coupon
		{
			get => _Coupon;
			set => _Coupon = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
