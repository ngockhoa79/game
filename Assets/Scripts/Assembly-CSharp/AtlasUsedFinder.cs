using System.Collections.Generic;
using UnityEngine;

public class AtlasUsedFinder : MonoBehaviour
{
	private List<string> SearchDirs;

	private List<string> AllPrefabFiles;

	private Dictionary<string, UIAtlas> atlasNameDic;

	private Dictionary<string, HashSet<string>> atlasToPrefabDic;

	private Dictionary<string, GameObject> atlasNodeDic;

	private Dictionary<string, HashSet<string>> atlasUsedSpriteDic;

	private int curIndex;

	private bool active;

	private GameObject TempRoot;

	private GameObject UsedPrefabRoot;

	private GameObject UnusedSpriteRoot;

	private void GenDirs()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void GenTargetsDic(UIAtlas[] _atlasArray)
	{
	}

	private void GenPrefabFiles()
	{
	}

	private void MakeIndex()
	{
	}

	private void HandlePrefab(int _index)
	{
	}

	private void OutputResult()
	{
	}
}
