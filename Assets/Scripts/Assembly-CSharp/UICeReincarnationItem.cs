using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICeReincarnationItem : MonoBehaviour
{
	public Color NameActiveColor;

	public Color NameInActiveColor;

	public Color DescActiveColor;

	public Color DescInActiveColor;

	private Rect LayoutRect;

	private const string ActiveBG = "ArrayCouplingActive";

	private const string InActiveBG = "ArrayCouplingInActive";

	private const string ActiveNameSlot = "ArrayCouplingTitleActive";

	private const string InActiveNameSlot = "ArrayCouplingTitleInActive";

	private const string FrameSpritePrefix = "Frame";

	private const string ResType = "icon_heroes";

	public UILabel Name;

	public UILabel Desc;

	public UISprite BG;

	public UISprite NameSlot;

	public UISprite Frame;

	public UISprite Cover;

	public UITexture Portrait;

	public UILabel Break;

	public void Set(Hero card, string name, string desc, bool isActive, int identifier)
	{
	}
}
