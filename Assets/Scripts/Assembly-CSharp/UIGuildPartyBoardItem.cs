using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildPartyBoardItem : MonoBehaviour
{
	[SerializeField]
	private UILabel president;

	[SerializeField]
	private UILabel vPresident;

	[SerializeField]
	private UILabel displayName;

	[SerializeField]
	private UILabel energyValue;

	[SerializeField]
	private UILabel fullText;

	[SerializeField]
	private UILabel halfText;

	[SerializeField]
	private UILabel xdLabel;

	[SerializeField]
	private UILabel xdDescLabel;

	public void Set(GuildMemberInfoProto.TypeEnum t, string n, int v, string xd)
	{
	}
}
