using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class FerrersArray : IceUIBase
{
	private S2CGetBondPositionInfoAck ackProto;

	public List<UIAeSlot> Slots;

	public ArrayTipsCtr Tips;

	public static Action BackFetter;

	private int[] SlotsHerosIndex;

	public static Action UpdateAction;

	public static Dictionary<int, int> InsTabel;

	private void Start()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void MyInit()
	{
	}

	private int CheckHero(S2CGetBondPositionInfoAck ack, int i)
	{
		return 0;
	}

	public void Back()
	{
	}

	public int GetCoplingLevel(int index)
	{
		return 0;
	}

	private void InitTable()
	{
	}

	public static int GetstaticCoplingLevel(int index)
	{
		return 0;
	}

	private void BuyJiBanLan(int PosionIndex)
	{
	}

	private int NeedDiamondsWithLv(int Pos, int NowLv)
	{
		return 0;
	}
}
