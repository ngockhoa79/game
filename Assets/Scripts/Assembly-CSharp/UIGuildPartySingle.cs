using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildPartySingle : MonoBehaviour
{
	public UIGuildPartyScrollingBoard Board;

	public UIGuildPartyMenuItem Menu;

	public UILabel Participation;

	public UILabel PresidentName;

	public UILabel EnergyLabel;

	public Transform FunnyRendererPlaceHolder;

	public IceAnimatorTotalCommander Anim;

	private UIHeroLoader uiHeroLoader;

	private int leader;

	private GuildPartyTemplate t;

	private int pCurrent;

	private int pMax;

	private List<GuildPartyInfoProto.PartyRecordProto> scrollingInfo;

	public void Set(bool already, int menuid, List<GuildPartyInfoProto.PartyRecordProto> scrollingInfo, string name, int leader, int pCurrent, int pMax)
	{
	}

	private void handleSpineIssue()
	{
	}

	private void handleMenuClicked(GuildPartyTemplate t)
	{
	}

	private void req()
	{
	}

	private string getTipXianDouDesc(GuildPartyTemplate.ItemBonus_ bonus)
	{
		return null;
	}

	private void Update()
	{
	}

	private void RefreshDynaticData()
	{
	}

	private void ack()
	{
	}

	private void tip(string t)
	{
	}

	private void loadSpineUgly(Shader topShader)
	{
	}

	public void ExhibitSpine(bool show)
	{
	}
}
