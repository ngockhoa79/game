using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeupDataCtrller : MonoBehaviour
{
	public GameObject MaxText;

	public UILabel BeforeBreakCounter;

	public UILabel AfterBreakCounter;

	public UILabel BeforeLv;

	public UILabel AfterLv;

	public UICmItemIcon BeforeSkill;

	public UICmItemIcon AfterSkill;

	public UICardWakupAoyiItemCtrller[] BeforeAoyiArray;

	public UICardWakupAoyiItemCtrller[] AfterAoyiArray;

	public GameObject[] Arrows;

	private Hero card;

	private HeroConfig afterCard;

	private TipTriger beforeSkillTip;

	private TipTriger afterSkillTip;

	private Color FullLvColor;

	private Color NotFullLvColor;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}

	private void RefreshUI()
	{
	}

	private void BindTips(GameObject _obejct, Thing _thing, TipTriger _triger)
	{
	}

	private string GenBreakCounterText(int _counter)
	{
		return null;
	}
}
