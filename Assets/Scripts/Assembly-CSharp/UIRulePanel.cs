using UnityEngine;

public class UIRulePanel : UIConvoyPopupBase
{
	public enum UIMode
	{
		UIRulePanel_Rule = 0,
		UIRulePanel_ConvoyLootRecord = 1
	}

	public UIEventListener closeButton;

	public UILabel rulesContent;

	public UIScrollView ScrollView;

	public UIPanel ScrollViewPanel;

	public GameObject EventBlocker;

	public GameObject TitleRule;

	public GameObject TitleRecord;

	private UIMode panelMode;

	public UIMode PanelMode
	{
		get
		{
			return default(UIMode);
		}
		set
		{
		}
	}

	protected override void SetID()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetDataByID(string ruleStringID)
	{
	}

	public void SetDataByContentWithColor(string ruleContent)
	{
	}

	private void onClose(GameObject btn)
	{
	}

	public override void ClosePanel()
	{
	}
}
