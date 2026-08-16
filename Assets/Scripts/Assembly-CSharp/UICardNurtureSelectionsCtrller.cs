using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardNurtureSelectionsCtrller : MonoBehaviour
{
	public enum NurtureType
	{
		Normal = 0,
		NormalX10 = 1,
		Advanced = 2,
		AdvancedX10 = 3,
		NormalXX = 4,
		AdvamcedXX = 5
	}

	public UIToggle[] Selections;

	public GameObject Mask;

	public IceAnimatorTotalCommander AnimRoot;

	public IceAnimatorTotalCommander[] Anims;

	public GameObject XiandouCostRoot;

	public GameObject CrystalCostRoot;

	public UILabel XiandouCostLabel;

	public UILabel CrystalCostLabel;

	private const int NurtureTypeToggleGroupID = 30;

	private Hero card;

	private bool locked;

	private int xiandouNeed;

	private int crystalNeed;

	public NurtureType currentType;

	public int XianDouCost => 0;

	public int CrystalCost => 0;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}

	public void SetLock(bool _lock)
	{
	}

	private void RefreshUI()
	{
	}

	public void OnTypeChanged()
	{
	}
}
