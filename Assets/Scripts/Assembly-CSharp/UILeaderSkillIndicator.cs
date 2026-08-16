using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILeaderSkillIndicator : MonoBehaviour
{
	private const string Nothing = "ArrayConfirmSkillSlotBlack";

	private const string Something = "ArrayConfirmSkillBtn";

	private const string LeaderSkillDuplicatedTip = "leader_skill_tip";

	[SerializeField]
	private UILabel SkillLabel;

	[SerializeField]
	private GameObject DisableCover;

	[SerializeField]
	private UISprite Icon;

	[SerializeField]
	private UIEventListener listener;

	private AutoTipTriger tip;

	public void Set(Hero leader, bool newLineRedTip, bool duplicate)
	{
	}

	private void setTip(string desc, bool newLineRedTip)
	{
	}

	private TipData createTipData(string sentence, Transform parent)
	{
		return null;
	}
}
