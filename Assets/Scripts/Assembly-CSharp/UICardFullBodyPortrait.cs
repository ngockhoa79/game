using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardFullBodyPortrait : IceUIBase
{
	[SerializeField]
	private UITexture BodyPotrait;

	[SerializeField]
	private UISprite CaseFrame;

	[SerializeField]
	private UISprite BaseLine;

	[SerializeField]
	private UICmStarDisplayer imgStarsBg;

	[SerializeField]
	private UICmStarDisplayer imgStars;

	[SerializeField]
	private UISprite imgCardType;

	[SerializeField]
	private UILabel CardName;

	[SerializeField]
	private UIEventListener btnCollider;

	[SerializeField]
	private UITexture tarTexture;

	private string caseHeadStr;

	private HeroConfig card;

	public HeroConfig Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void DoClearData()
	{
	}

	private void clear()
	{
	}

	private void set(HeroConfig card)
	{
	}

	private string caseNameBody(HeroConfig card)
	{
		return null;
	}

	public void onLoadTexture()
	{
	}

	protected override void DoDispose()
	{
	}
}
