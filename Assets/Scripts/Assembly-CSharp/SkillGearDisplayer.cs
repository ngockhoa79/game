using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class SkillGearDisplayer : MonoBehaviour
{
	public UISprite Icon;

	public UISprite Frame;

	public Transform StarsPlaceHolder;

	private UIStars stars;

	public UILabel SkillTypeText;

	public UILabel GearLevelText;

	public GameObject TextNode;

	public GameObject LevelTextNode;

	public GameObject SkillTextNode;

	public const string EMPTY_SLOT_ICON_SPRITE_NAME = "EmptySlot";

	public const string DISABLED_ICON_SPRITE_NAME = "EmptySlot";

	public const string EMPTY_FRAME_SPRITE_NAME = "SkillWhite";

	public const string DISABLED_FRAME_SPRITE_NAME = "SkillWhite";

	private bool isEnabled;

	private bool isSimpleMode;

	private Skill skill;

	public bool IsSimpleMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Skill Skill
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void prepareWidgets()
	{
	}

	public void Clear()
	{
	}

	public bool IsEnabled()
	{
		return false;
	}

	public void Disable()
	{
	}
}
