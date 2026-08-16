using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.GameOperations;
using UnityEngine;

public class DrawCardMoudle
{
	private static PlayerLotteryInfoProto mProto;

	public static C2SHeroLotteryReq.LotteryType LastDrawType { get; private set; }

	public static PlayerLotteryInfoProto DrawCardInfo
	{
		get
		{
			if (mProto == null)
			{
				mProto = new PlayerLotteryInfoProto();
			}
			return mProto;
		}
		set
		{
			mProto = value;
		}
	}

	public static DateTime NextFreeTimeFriend { get; private set; }

	public static DateTime NextFreeTimeDiamond { get; private set; }

	public static void SetNextFreeTimeFriend(long tick)
	{
	}

	public static void SetNextFreeTimeDiamond(long tick)
	{
	}

	public static bool IsFreeToDraw(C2SHeroLotteryReq.LotteryType type)
	{
		return false;
	}

	public static void drawAgainAsLast(Action<List<ItemHolding>> onShow, Action onFail)
	{
		drawCardByDiamond10(onShow, onFail);
	}

	public static void drawCardByFriend(Action<List<ItemHolding>> onShow, Action onFail)
	{
	}

	public static void drawCardByDiamond(Action<List<ItemHolding>> onShow, Action onFail)
	{
	}

	public static void drawCardByDiamond10(Action<List<ItemHolding>> onShow, Action onFail)
	{
		var req = new C2SHeroLotteryReq
		{
			Type = C2SHeroLotteryReq.LotteryType.DiamondTen
		};

		Action<S2CHeroLotteryAck> handler = null;
		handler = (ack) =>
		{
			NetManager.Instance.E_OnHeroLotteryAck -= handler;
			Debug.Log($"[DRAWCARD-MODULE] S2CHeroLotteryAck received! Code={ack?.Code}, HerosCount={ack?.Heros?.Count}");
			if (ack != null && ack.Code == S2CHeroLotteryAck.ResultCode.Success)
			{
				List<ItemHolding> holdings = new List<ItemHolding>();
				if (ack.Heros != null)
				{
					foreach (var h in ack.Heros)
					{
						holdings.Add(new ItemHolding(null, h.Index, h.Count));
					}
				}

				if (DrawCardInfo != null)
				{
					DrawCardInfo.TryDiamondMustGetPurpleCount = ack.TryDiamondMustGetPurpleCount;
					DrawCardInfo.IsDiamondFirstAlready = ack.IsDiamondFirstAlready;
				}

				onShow?.Invoke(holdings);
			}
			else
			{
				onFail?.Invoke();
			}
		};

		NetManager.Instance.E_OnHeroLotteryAck += handler;
		Debug.Log("[DRAWCARD-MODULE] Sending C2SHeroLotteryReq (MsgId 1246, Type=DiamondTen)...");
		NetManager.Instance.SendPacket(1246, req);
	}

	private static void drawCard(DrawCardOp r, Action<List<ItemHolding>> onShow, Action onFail)
	{
	}

	public static int GetCostFriend()
	{
		return 0;
	}

	public static int GetCostDraw()
	{
		return 270;
	}

	public static int GetCostDraw10()
	{
		return 2700;
	}
}
