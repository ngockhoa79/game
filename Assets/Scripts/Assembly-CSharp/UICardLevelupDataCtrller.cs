using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardLevelupDataCtrller : MonoBehaviour
{
	private enum CardStatus
	{
		Level = 0,
		HP = 1,
		ATK = 2,
		DEF = 3,
		SPI = 4
	}

	[SerializeField]
	private UILabel[] OrgStatus;

	[SerializeField]
	private UILabel[] NewStatus;

	private Hero card;

	private int afterLevel;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}

	public void SetAfterLevel(int _level)
	{
	}

	public void ClearLabels(bool _left)
	{
	}

	private void SetPridictData()
	{
	}

	private int checkUpAttr(int baseLevel, int maxLevel, int baseValue, int maxValue, int levelDelta)
	{
		return 0;
	}
}
