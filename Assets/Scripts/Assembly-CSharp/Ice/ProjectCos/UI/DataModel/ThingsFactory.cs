using Ice.ProjectCos.Protocol;
using UnityEngine;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ThingsFactory : MonoBehaviour
	{
		public static Thing CreateThingFromProto(ItemChangeProto proto)
		{
			return null;
		}

		public static Thing CreateThing(ItemChangeProto.ItemType type, int id)
		{
			return null;
		}

		public static ThingHolding CreateThingHolding(ItemChangeProto.ItemType type, int id, int count, int index = -1)
		{
			return null;
		}

		public static ThingHolding CreateThingHoldingFromThingProto(ThingProto po)
		{
			return null;
		}

		public static ThingHolding CreateHoldingFromProto(ItemChangeProto proto)
		{
			return null;
		}

		public static ThingHolding CreateThingHoldingForMail(MailAttachmentThingProto mt)
		{
			return null;
		}

		public static ThingHolding CreateHoldingForAchivement(int type, int id, int num)
		{
			return null;
		}

		public static PropertyThing CreatePropertyThing(int type)
		{
			return null;
		}

		private static PropertyHolding CreatePropertyHolding(int type, int count)
		{
			return null;
		}
	}
}
