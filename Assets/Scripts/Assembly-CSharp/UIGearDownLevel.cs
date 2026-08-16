using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearDownLevel : IceUIBase
{
	[SerializeField]
	private UIGearDisplayer GearDisplayer;

	[SerializeField]
	private UILabel lblStoneNimber;

	[SerializeField]
	private UILabel lblCrystalNumber;

	[SerializeField]
	private UILabel lblGearName;

	[SerializeField]
	private UISprite OrgMajorBufIcon;

	[SerializeField]
	private UISprite OrgMajorBufTxt;

	[SerializeField]
	private UISprite RefineMajorBufIcon;

	[SerializeField]
	private UISprite RefineMajorBufTxt;

	[SerializeField]
	private UILabel OrgMajorBufNumber;

	[SerializeField]
	private UILabel RefineMajorBufNumber;

	[SerializeField]
	private UILabel OrgMinorBuf1Number;

	[SerializeField]
	private UILabel OrgMinorBuf1Empty;

	[SerializeField]
	private UILabel RefineMinorBuf1Number;

	[SerializeField]
	private UILabel OrgMinorBuf2Number;

	[SerializeField]
	private UILabel OrgMinorBuf2Empty;

	[SerializeField]
	private UILabel RefineMinorBuf2Number;

	[SerializeField]
	private UISprite OrgMinorBuf1Txt;

	[SerializeField]
	private UISprite RefineMinorBuf1Txt;

	[SerializeField]
	private UISprite OrgMinorBuf2Txt;

	[SerializeField]
	private UISprite RefineMinorBuf2Txt;

	[SerializeField]
	private UISprite OrgMinorBuf1Question;

	[SerializeField]
	private UISprite OrgMinorBuf2Question;

	[SerializeField]
	private UILabel lblRefineLevel;

	[SerializeField]
	private UILabel lblClearPrice;

	[SerializeField]
	private UILabel lblDownPrice;

	[SerializeField]
	private UILabel lblClearTips;

	[SerializeField]
	private UILabel lblDownTips;

	public UIEventListener CloseButton;

	public UIEventListener ClearButton;

	public UIEventListener DownButton;

	public GearHolding holding;

	private int PreMajorValue;

	private EAttrType MinorBuf1;

	private EAttrType MinorBuf2;

	private int MinorBuf1Value;

	private int MinorBuf2Value;

	public void SetData(GearHolding holding, int PreMajorValue = 0, EAttrType MinorBuf1 = EAttrType.None, int MinorBuf1Value = 0, EAttrType MinorBuf2 = EAttrType.None, int MinorBuf2Value = 0)
	{
	}

	private void ResetValue()
	{
	}

	public void Clear()
	{
	}

	private void OnDownLevelClicked(GameObject obj)
	{
	}

	private void OnClearLevelClicked(GameObject obj)
	{
	}
}
