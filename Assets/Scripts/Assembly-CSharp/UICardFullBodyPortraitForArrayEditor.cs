using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardFullBodyPortraitForArrayEditor : IceUIBase
{
	public enum TextureType
	{
		Head = 0,
		FullBody = 1
	}

	public TextureType TT;

	private const string Transparent = "Texture/EmptySlot";

	private const string ResTypeImage = "cardimages";

	private const string ResTypeHead = "icon_heroes";

	[SerializeField]
	private UITexture BodyPotrait;

	[SerializeField]
	private UISprite CaseGroup;

	[SerializeField]
	private UICmStarDisplayer imgStars;

	[SerializeField]
	private UISprite imgCardType;

	public UIEventListener CtrlListener;

	public GameObject[] FrameGroups;

	[SerializeField]
	private UITexture tarTexture;

	public UILabel CardName;

	public bool Covered;

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

	private void initCaseStarsJobType()
	{
	}

	private void hideFrame()
	{
	}

	private void frame(ERarity r)
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
