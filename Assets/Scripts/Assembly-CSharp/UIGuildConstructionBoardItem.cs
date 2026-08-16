using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildConstructionBoardItem : MonoBehaviour
{
	[SerializeField]
	private UILabel president;

	[SerializeField]
	private UILabel vPresident;

	[SerializeField]
	private UILabel displayName;

	[SerializeField]
	private UILabel activeValue;

	[SerializeField]
	private UILabel[] constructionType;

	public void Set(GuildMemberInfoProto.TypeEnum t, string n, int index, int v)
	{
	}
}
