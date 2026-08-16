using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UI4CardDisplayer : MonoBehaviour
{
	[SerializeField]
	private UITexture Image;

	[SerializeField]
	private UISprite CardFrame;

	[SerializeField]
	private UICmStarDisplayer Stars;

	[SerializeField]
	private UISprite ProfessionIcon;

	[SerializeField]
	private UILabel CardName;

	[SerializeField]
	private UILabel WakeupLabel;

	private string frameNamePrefix;

	private HeroConfig card;

	public void SetHero(HeroConfig _card)
	{
	}

	private string GetFrameByRarity(HeroConfig card)
	{
		return null;
	}

	private void LoadTexture()
	{
	}

	public void Dispose()
	{
	}

	private void clear()
	{
	}
}
