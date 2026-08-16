using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeupResultPanelCtrller : MonoBehaviour
{
	public CardBig cardBig;

	public IceAnimatorTotalCommander wakeAnim;

	public GameObject[] rarityBgAnims;

	public float switchCardTime;

	public float showButtonTime;

	public UILabel beforeLv;

	public UILabel afterLv;

	public UniIcon beforeSkill;

	public UniIcon afterSkill;

	public UILabel aoyiLabel;

	public UIEventListener confirmBtn;

	private Action OnEnsue;

	private bool canEnsure;

	private HeroConfig beforeCard;

	private HeroConfig afterCard;

	public void Prepare(Action _onEnsure)
	{
	}

	public void ClearData()
	{
	}

	public void SetData(HeroConfig _beforeCard, HeroConfig _afterCard)
	{
	}

	private void SetUI()
	{
	}

	public void PlayAnim()
	{
	}

	private void EnsureWakeup(GameObject _object)
	{
	}
}
