using Ice.ProjectCos.Protocol;
using UnityEngine;

public class DayRechargContent : MonoBehaviour
{
	public UIEventListener GotBtnActive;

	public UIGrid Mgrid;

	public UILabel ChargeDiamonds;

	public GameObject UIcon;

	public GameObject GotBtnInActive;

	public GameObject GotBtnRecieved;

	public UIEventListener GotTotalBtn;

	private int Mindex;

	private ExpenseInfoProto.ConfigProto.Slot sl;

	private C2SContinueChargeInfoAck Minfo;

	public void SetData(ExpenseInfoProto.ConfigProto.Slot slot, int indexMark, int MyIndex, int Count, int TotalCount, bool Week = false)
	{
	}

	public void SetContinueChargeData(C2SContinueChargeInfoAck reward, int Type)
	{
	}

	private void ContinueChargePick(GameObject Obj)
	{
	}

	private void ContinueChargeBuy(GameObject Obj)
	{
	}

	public void GetRewardRequest(GameObject OBJ)
	{
	}

	public void GetWeekRewardRequest(GameObject OBJ)
	{
	}
}
