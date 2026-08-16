using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgCardDisplayer : MonoBehaviour
{
	public enum EMode
	{
		Viewer = 0,
		Maker = 1,
		Seller = 2
	}

	public delegate void ButtonListener(Hero card);

	public Transform PortraitPlaceHolder;

	public Transform StarsPlaceHolder;

	public UILabel NameText;

	public UILabel LevelText;

	public UILabel PowerText;

	public UILabel FragmentsText;

	public GameObject FragmentsDisplayer;

	public UISprite ButtonForeground;

	public UIEventListener Button;

	private UIAeCardDisplayer portrait;

	private UIStars stars;

	public const string VIEWER_BUTTON_FOREGROUND = "TxtStrengthenYellow";

	public const string MAKER_BUTTON_FOREGROUND = "TxtSummon";

	public const string SELLER_BUTTON_FOREGROUND = "TxtSelect";

	private EMode mode;

	private int fragCount;

	private int fragReq;

	private Hero card;

	public EMode Mode
	{
		get
		{
			return default(EMode);
		}
		set
		{
		}
	}

	public int FragmentsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int FragmentsRequirement
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event ButtonListener OnButton
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void prepareWidgets()
	{
	}

	private void OnDestroy()
	{
	}

	private void checkFragments()
	{
	}
}
