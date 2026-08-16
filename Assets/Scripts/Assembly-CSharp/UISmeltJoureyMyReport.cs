using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISmeltJoureyMyReport : MonoBehaviour
{
	[Serializable]
	public class RowStruct
	{
		public GameObject Content;

		public GameObject Separator;
	}

	public RowStruct[] Rows;

	public UILabel LblTopPlayer;

	public UILabel LblTopWinrate;

	public UILabel LblSuperRank;

	public UILabel LblSuperWinrate;

	public UILabel LblNormalRank;

	public UILabel LblNormalWinrate;

	public UILabel LblNormalWin;

	public UILabel LblSuperWin;

	public UILabel LblCoin;

	public UITable Table;

	public UIEventListener eventOk;

	public Action E_OnOK;

	public GameObject goNo1;

	public GameObject goMe;

	private void Start()
	{
	}

	private void Destroy()
	{
	}

	public void SetData(TrialRecordProto recordProto)
	{
	}
}
