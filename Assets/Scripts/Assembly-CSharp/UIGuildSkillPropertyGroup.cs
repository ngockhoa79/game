using UnityEngine;

public class UIGuildSkillPropertyGroup : MonoBehaviour
{
	private string[] PropertyIcons;

	private string[] PropertyWords;

	[SerializeField]
	private UISprite PropertyIcon;

	[SerializeField]
	private UISprite PropertyName;

	[SerializeField]
	private UISprite MaxIcon;

	[SerializeField]
	private UISprite Arrow;

	[SerializeField]
	private UILabel PropertyFrom;

	[SerializeField]
	private UILabel PropertyTo;

	public void Set(int curLv, int max, int t, int n)
	{
	}
}
