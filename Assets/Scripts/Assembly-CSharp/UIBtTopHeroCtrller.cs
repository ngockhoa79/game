using UnityEngine;

public class UIBtTopHeroCtrller : MonoBehaviour
{
	private enum BarStyle
	{
		Red = 0,
		Blue = 1,
		Green = 2,
		Count = 3
	}

	public GameObject inIceAnimation;

	public GameObject Root;

	public FeaturedProgress hpBar;

	public UIBtTopBuffCtrller buffCtrller;

	public UISprite HeadFrame;

	public IceNGUIAlphaAnimator WarningAnim;

	public Animation XAnim;

	public GameObject LeaderIcon;

	public GameObject SupportIcon;

	public UISprite ProfessionIcon;

	public UITexture HeadIcon;

	private UIBtFighterInfo heroInfo;

	private bool dead;

	private Color BlueMiddleColor;

	private Color RedMiddleColor;

	private Color GreenMiddleColor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Init()
	{
	}

	public void SetHeroInfo(UIBtFighterInfo _info)
	{
	}

	public void FighterDie()
	{
	}

	public void PlayInAnim(float _delay)
	{
	}

	public void ResetInAnim()
	{
	}

	public void PlayLeaderIconAnim()
	{
	}

	public void PlaySupportIconAnim()
	{
	}

	public void AddBuff(int _buffId)
	{
	}

	public void RemoveBuff(int _buffId)
	{
	}

	public void ClearBuffs()
	{
	}
}
