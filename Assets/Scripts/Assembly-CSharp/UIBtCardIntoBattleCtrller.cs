using UnityEngine;

public class UIBtCardIntoBattleCtrller : MonoBehaviour
{
	public GameObject cardIntoRoot;

	public GameObject turnHeroRoot;

	public Transform maskTran;

	public Transform unmaskTran;

	public HeroProfession professionNode;

	public GameObject maskRarityNode;

	public GameObject unmaskRarityNode;

	public UIPanel groundPanel;

	public UIPanel maskPanel;

	public UIPanel unmaskPanel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetPanelsDepth(int _depth)
	{
	}

	public void ShowCardIntoAnim()
	{
		if (cardIntoRoot != null) cardIntoRoot.SetActive(true);
	}

	public void ShowTurnHeroAnim()
	{
		if (turnHeroRoot != null) turnHeroRoot.SetActive(true);
	}

	public void SetCardInfo(UIBtCardIntoBattleInfo _info)
	{
	}
}
