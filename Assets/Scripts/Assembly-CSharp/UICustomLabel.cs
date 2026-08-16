using System.Collections.Generic;
using UnityEngine;

public class UICustomLabel : MonoBehaviour
{
	public const string KEY_RETURN = "/return";

	public const string KEY_CRYSTAL = "/crystal";

	public const string KEY_ALARM = "/alarm";

	public const string KEY_GOLD = "/gold";

	public const string KEY_REBORN = "/relive";

	public const string KEY_GEARSTONE_1 = "/gearstone1";

	public const string KEY_GEARSTONE_2 = "/gearstone2";

	public const string KEY_GEARSTONE_3 = "/gearstone3";

	public const string KEY_GEARSTONE_4 = "/gearstone4";

	public const string KEY_GEARSTONE_5 = "/gearstone5";

	public const string KEY_VIP_Prefix = "/vip";

	public const string KEY_VIP_0 = "/vip00";

	public const string KEY_VIP_1 = "/vip01";

	public const string KEY_VIP_2 = "/vip02";

	public const string KEY_VIP_3 = "/vip03";

	public const string KEY_VIP_4 = "/vip04";

	public const string KEY_VIP_5 = "/vip05";

	public const string KEY_VIP_6 = "/vip06";

	public const string KEY_VIP_7 = "/vip07";

	public const string KEY_VIP_8 = "/vip08";

	public const string KEY_VIP_9 = "/vip09";

	public const string KEY_VIP_10 = "/vip10";

	public const string KEY_VIP_11 = "/vip11";

	public const string KEY_VIP_12 = "/vip12";

	public const string KEY_VIP_13 = "/vip13";

	public const string KEY_VIP_14 = "/vip14";

	public const string KEY_VIP_15 = "/vip15";

	public const string WORD_LINE_PREFIX = "Line_";

	public const string WORD_WORD_PREFIX = "Word_";

	public const int SpacingX = 0;

	[SerializeField]
	private string text;

	[SerializeField]
	private UILabel sampleLabel;

	[SerializeField]
	private int depth;

	[SerializeField]
	private int deltaY;

	private GameObject root;

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Refresh()
	{
	}

	private void ProcessLine(string lineWord, int line_index, int line_max)
	{
	}

	private List<string> SplitByKeyword(List<string> input, string keyword)
	{
		return null;
	}

	public void ClearData()
	{
	}

	private GameObject GetParentByLine(int lineId)
	{
		return null;
	}

	private GameObject CreateObjectByWord(string word, int idx, Transform parent)
	{
		return null;
	}

	private void DoArrangeWords(List<GameObject> objs)
	{
	}

	private void DoArrangeLine(GameObject lineGo, int line_index, int line_max)
	{
	}
}
