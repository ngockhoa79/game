using Ice.ProjectCos.Protocol;
using UnityEngine;

public class CrossPkBattleResultCtrller : MonoBehaviour
{
	public GameObject winLog;

	public GameObject loseLog;

	public UISprite leftIcon;

	public UILabel leftServer;

	public UILabel leftName;

	public UISprite rightIcon;

	public UILabel rightServer;

	public UILabel rightName;

	public UILabel turn;

	public UILabel totalScore;

	public UILabel turn1stScore;

	public UILabel turn2ndScore;

	public UILabel guildPoint;

	public UILabel guildRank;

	public UILabel guildWinCounter;

	public UILabel guildBatterWin;

	public UILabel guildExpAdd;

	public UILabel myName;

	public UILabel myLv;

	public UILabel myKill;

	public UILabel myLose;

	public UniIcon[] rewards;

	public UILabel Title1turn;

	public UILabel Title2turn;

	public UISprite spvip;

	public UITexture txheadicon;

	public UIEventListener MemResultBtn;

	public UIEventListener ConfirmBtn;

	public UILabel NoInTip;

	public GameObject RewardContent;

	private bool hasReward;

	private bool targetNull;

	public void SetData(CrossGuildBattleOverPlayerRewardProto proto)
	{
	}

	private void setRewardIcon(CrossGuildBattleOverProto.RewardOfPlayerProto proto)
	{
	}

	private void setHeadIcon()
	{
	}

	private void tip(string t)
	{
	}

	private void OnMemResultBtnClicked(GameObject _obj)
	{
	}

	private void OnConfirmBtnClicked(GameObject _obj)
	{
	}

	public void Clear()
	{
	}
}
