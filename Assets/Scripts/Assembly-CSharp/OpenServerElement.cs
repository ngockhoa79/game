using Ice.ProjectCos.ConfigGenerator.Template;

public class OpenServerElement
{
	public enum PrefabCategory
	{
		StyleComplex = 0,
		StyleSimplex = 1
	}

	public enum TemplateCategory
	{
		Reward = 0,
		Sale = 1,
		Task = 2
	}

	public PrefabCategory PC;

	public TemplateCategory TC;

	public int SignDay;

	public OpenServerRewardTemplate.RewardItem_ RewardItem;

	public UIOpenServerItemComplex.BtnType BtnType;

	public int Id;

	public OpenServerSaleItemTemplate.Item[] Items;

	public int VipCondition;

	public int InitialPrice;

	public int NowPrice;

	public int New;

	public int TotallyLimitation;

	public int Hot;

	public string TaskIcon;

	public int PurchaseCount;

	public int Type;

	public OpenServerTaskTemplate.TaskInfo_ TaskInfo;

	public int CurrentValue;

	public OpenServerTaskTemplate.Access[] Accesss;

	public OpenServerTaskTemplate.RewardItem[] RewardItems;

	public UIOpenServerItemSimplex.BtnType BtnType_;

	public bool ShowRedDot;

	public OpenServerElement(OpenServerRewardTemplate r)
	{
	}

	public OpenServerElement(OpenServerSaleItemTemplate s)
	{
	}

	public OpenServerElement(OpenServerTaskTemplate t)
	{
	}
}
