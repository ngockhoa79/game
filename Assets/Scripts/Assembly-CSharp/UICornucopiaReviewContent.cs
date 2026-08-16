using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UICornucopiaReviewContent : IceUIBase
{
	public enum EState
	{
		Normal = 0,
		FinalRewardAll = 1,
		FinalRewardAttend = 2
	}

	[SerializeField]
	private UILabel lbDay;

	[SerializeField]
	private UniIcon icon1;

	[SerializeField]
	private UniIcon icon2;

	[SerializeField]
	private UniIcon icon3;

	[SerializeField]
	private UISprite spBackground;

	[SerializeField]
	private UISprite spFinalRewardsAll;

	[SerializeField]
	private UISprite spFinalRewardsAttend;

	private const string BGSrpiteName = "Con_bg_Content";

	public void SetData(int day, List<ThingProto> items, EState state)
	{
	}
}
