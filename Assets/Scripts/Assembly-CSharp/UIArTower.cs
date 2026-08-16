using UnityEngine;

public class UIArTower : IceUIBase
{
	public Transform[] PlayerSlots;

	public Transform[] CloudSlots;

	public Transform LightTrans;

	private int size;

	public int AvailableSlotCount => 0;

	protected override void DoInit()
	{
	}

	public Transform PopSlot()
	{
		return null;
	}

	protected override void DoDispose()
	{
	}
}
