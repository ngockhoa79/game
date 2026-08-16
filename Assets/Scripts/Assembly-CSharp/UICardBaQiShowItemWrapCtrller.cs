using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiShowItemWrapCtrller : MonoBehaviour
{
	[SerializeField]
	public Transform icon;

	[SerializeField]
	private UILabel count;

	[SerializeField]
	private UIEventListener lister;

	[SerializeField]
	private UICardBaQiLabelProperty propAtk;

	[SerializeField]
	private UICardBaQiLabelProperty propLife;

	[SerializeField]
	private UICardBaQiLabelProperty propMind;

	[SerializeField]
	private UISprite iconMask;

	private CardBaQiItem data;

	private UniIcon unicon;

	public void init()
	{
	}

	public void destory()
	{
	}

	private void onClick(GameObject obj)
	{
	}

	private void clearUnicon()
	{
	}

	public void setData(CardBaQiItem data)
	{
	}

	public void AddIcon(ThingHolding h, Transform parent)
	{
	}
}
