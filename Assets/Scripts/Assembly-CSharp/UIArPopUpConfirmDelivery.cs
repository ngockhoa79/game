using System;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIArPopUpConfirmDelivery : IceUIBase
{
	public bool ActiveSpine;

	public const string Tip = "red_packet_tips_5";

	public Action OnConfirm;

	public UIEventListener ConfirmBtn;

	public UIEventListener CancelBtn;

	public UILabel RedPackages;

	public UILabel Currency;

	public UILabel Desc;

	public UniIcon reward1;

	public UniIcon reward2;

	public GameObject[] TypeSpecified;

	protected override void DoInit()
	{
	}

	public void SetDetail(C2SRedPackListReq.TypeEnum t, int rank)
	{
	}

	private void setTypeSpecified(bool isNormal)
	{
	}

	private void set(RedPackTemplateExt item, C2SRedPackListReq.TypeEnum t)
	{
	}

	private void ShowIcon(int index, RedPackTemplateExt.Drop drop)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}
