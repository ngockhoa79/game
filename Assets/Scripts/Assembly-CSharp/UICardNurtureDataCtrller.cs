using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardNurtureDataCtrller : MonoBehaviour
{
	public enum CardStatus
	{
		HP = 0,
		ATK = 1,
		DEF = 2,
		SPI = 3,
		_NUM = 4
	}

	public UILabel LvLabel;

	public UILabel PotentialLabel;

	public UILabel PotentialDeltaLabel;

	public UILabel[] BeforeStatus;

	public UILabel[] AfterStatus;

	public UILabel[] DeltaStatus;

	private Hero card;

	private int afterLevel;

	private Color subColor;

	private Color addColor;

	private Color normalColor;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}

	public void SetChangeInfo(HeroNurtureInfoProto _infoChange)
	{
	}

	private void SetChangeLabel(CardStatus _status, int _delta)
	{
	}

	public void ClearLabels(bool _left)
	{
	}
}
