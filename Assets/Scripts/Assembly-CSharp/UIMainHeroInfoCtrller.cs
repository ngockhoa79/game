using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMainHeroInfoCtrller : MonoBehaviour
{
	public UISprite Background;

	public UILabel LvLabel;

	public UILabel MaxLvLabel;

	public UISprite Profession;

	public GameObject StarsRoot;

	public UIEventListener btnShowDetail;

	private Hero _myHero;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetInfo(Hero _hero)
	{
		_myHero = _hero;
		if (_hero == null) return;
		if (LvLabel != null)
		{
			LvLabel.text = _hero.Level.ToString();
		}
		if (MaxLvLabel != null)
		{
			MaxLvLabel.text = _hero.Config.MaxLevel.ToString();
		}
	}

	private void OnDestroy()
	{
	}
}
