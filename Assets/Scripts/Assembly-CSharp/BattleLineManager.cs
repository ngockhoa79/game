using System.Collections.Generic;
using UnityEngine;

public class BattleLineManager : MonoBehaviour
{
	private class SmallLineInfo
	{
		public int smallLineIndex;

		public int fighterId;

		public BattleHeroInfo heroInfo;
	}

	private static BattleLineManager _instance;

	private Dictionary<int, SmallLineInfo> leftLines;

	private Dictionary<int, SmallLineInfo> rightLines;

	public static BattleLineManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = UnityEngine.Object.FindObjectOfType<BattleLineManager>();
			}
			return _instance;
		}
	}

	public void DestoryInstance()
	{
		_instance = null;
	}

	public void SetFighterSmallLine(BattleHeroInfo _heroInfo, bool _forceMiddle)
	{
		if (_heroInfo == null) return;
		if (leftLines == null) leftLines = new Dictionary<int, SmallLineInfo>();
		if (rightLines == null) rightLines = new Dictionary<int, SmallLineInfo>();

		SmallLineInfo info = new SmallLineInfo();
		info.fighterId = _heroInfo.FighterId;
		info.heroInfo = _heroInfo;
		info.smallLineIndex = (int)_heroInfo.SmallLine;

		Dictionary<int, SmallLineInfo> targetDic = _heroInfo.IsLeft ? leftLines : rightLines;
		targetDic[_heroInfo.FighterId] = info;
	}

	public void RemoveFighter(int _fighterId)
	{
		if (leftLines != null) leftLines.Remove(_fighterId);
		if (rightLines != null) rightLines.Remove(_fighterId);
	}

	public void ClearAll()
	{
		if (leftLines != null) leftLines.Clear();
		if (rightLines != null) rightLines.Clear();
	}

	public int GetMainFighterInLine(int _line, bool _left)
	{
		Dictionary<int, SmallLineInfo> targetDic = _left ? leftLines : rightLines;
		if (targetDic == null) return 0;
		foreach (var kvp in targetDic)
		{
			if (kvp.Value != null && kvp.Value.smallLineIndex == _line)
			{
				return kvp.Value.fighterId;
			}
		}
		return 0;
	}

	private void RemoveItem(Dictionary<int, SmallLineInfo> _dic, int _key)
	{
		if (_dic != null) _dic.Remove(_key);
	}
}
