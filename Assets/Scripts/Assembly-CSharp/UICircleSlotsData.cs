using System;
using UnityEngine;

public class UICircleSlotsData : MonoBehaviour
{
	[Serializable]
	public class SlotContent
	{
		public GameObject[] objs;

		public int getSlotCount()
		{
			return 0;
		}
	}

	public SlotContent[] CircleSlotsList;
}
