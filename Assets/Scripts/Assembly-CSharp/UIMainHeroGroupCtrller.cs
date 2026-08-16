using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Ice.ProjectCos.UI.DataModel;

public class UIMainHeroGroupCtrller : MonoBehaviour
{
	public static Action AllLoadOverCallBack;

	private bool loaded;

	private List<int> currentArrayList;

	private Dictionary<int, GameObject> heroDic;

	private const int SHOW_HERO_NUM = 3;

	private const float HERO_GAP = 175f;

	private const float MAX_SCALE = 1.3f;

	private Vector3[] Hero_Poss;

	private Vector3[] Hero_Scales;

	private int needLoadCounter;

	private int loadCounter;

	private Transform holder;

	private Transform lender;

	public bool IsTricky => false;

	private void Start()
	{
		Debug.Log("[HERO-GROUP-DIAG] UIMainHeroGroupCtrller.Start() executing");
	}

	private void Update()
	{
		if (!loaded)
		{
			UpdateHeroInfo();
		}
	}

	public void ShowTeamHeros()
	{
		Debug.Log("[HERO-GROUP-DIAG] ShowTeamHeros executing");
		UpdateHeroInfo();
		Reposition();
	}

	public void HideTeamHeros()
	{
		if (heroDic != null)
		{
			foreach (var pair in heroDic)
			{
				if (pair.Value != null)
				{
					pair.Value.SetActive(false);
				}
			}
		}
	}

	public void DestoryAll()
	{
		if (heroDic != null)
		{
			foreach (var pair in heroDic)
			{
				if (pair.Value != null)
				{
					UnityEngine.Object.Destroy(pair.Value);
				}
			}
			heroDic.Clear();
		}
	}

	private void UpdateHeroInfo()
	{
		bool meValid = Me.Ins != null;
		bool setDataOk = meValid && Me.Ins.SetDataOk;
		var demoList = meValid ? Me.Ins.MainSceneDemonstrateHeroes : null;
		int demoCount = demoList != null ? demoList.Count : -1;
		Debug.Log($"[HERO-GROUP-DIAG] UpdateHeroInfo executing: Me.Ins!=null={meValid}, SetDataOk={setDataOk}, MainSceneDemonstrateHeroes.Count={demoCount}");

		if (Me.Ins == null || Me.Ins.MainSceneDemonstrateHeroes == null)
		{
			Debug.LogWarning("[HERO-GROUP] Me.Ins or MainSceneDemonstrateHeroes is null!");
			return;
		}
		currentArrayList = Me.Ins.MainSceneDemonstrateHeroes.Select(h => h.LocalID).ToList();
		if (heroDic == null)
		{
			heroDic = new Dictionary<int, GameObject>();
		}
		int currentCount = currentArrayList != null ? currentArrayList.Count : 0;
		Debug.Log($"[HERO-GROUP-DIAG] currentArrayList populated: count={currentCount}");

		if (currentArrayList == null || currentArrayList.Count == 0)
		{
			Debug.LogWarning("[HERO-GROUP] currentArrayList is empty!");
			return;
		}

		needLoadCounter = Mathf.Min(currentArrayList.Count, SHOW_HERO_NUM);
		loadCounter = 0;

		Debug.Log($"[HERO-GROUP] UpdateHeroInfo: needLoadCounter={needLoadCounter}");

		for (int i = 0; i < needLoadCounter; i++)
		{
			int heroId = currentArrayList[i];
			if (heroId <= 0) continue;

			if (!heroDic.ContainsKey(heroId))
			{
				string prefabPath = $"Prefabs/Hero/{heroId}";
				// [RECONSTRUCTED-DESIGN]
				// Native call requires loadResourceType, but exact literal could not
				// be resolved from IL2CPP metadata/native disassembly.
				// "Prefab" is selected because the resource path is Prefabs/Hero/{heroId}
				// and BuildTargetContent.ResourceEnum defines Prefab.
				GameObject prefab = GlobalManager.Instance.ResourcesManager != null ? GlobalManager.Instance.ResourcesManager.Instance<GameObject>(prefabPath, "Prefab") : Resources.Load<GameObject>(prefabPath);
				if (prefab != null)
				{
					CreateHero(prefab, heroId);
				}
				else
				{
					Debug.LogWarning($"[HERO-GROUP] Hero prefab not found: {prefabPath}");
					LoadOneHeroOver();
				}
			}
			else
			{
				if (heroDic[heroId] != null)
				{
					heroDic[heroId].SetActive(true);
				}
				LoadOneHeroOver();
			}
		}
	}

	private void Reposition()
	{
		if (currentArrayList == null || heroDic == null) return;
		int count = 0;
		int total = Mathf.Min(currentArrayList.Count, SHOW_HERO_NUM);
		for (int i = 0; i < total; i++)
		{
			int heroId = currentArrayList[i];
			if (heroDic.TryGetValue(heroId, out GameObject heroObj) && heroObj != null)
			{
				float xPos = (count - 1) * HERO_GAP;
				heroObj.transform.localPosition = new Vector3(xPos, 0f, 0f);
				float scale = (count == 1) ? MAX_SCALE : 1.0f;
				heroObj.transform.localScale = new Vector3(scale, scale, scale);
				count++;
			}
		}
	}

	private void CreateHero(GameObject _prefab, int _heroId)
	{
		if (_prefab == null) return;
		GameObject heroObj = UnityEngine.Object.Instantiate(_prefab);
		if (holder != null)
		{
			heroObj.transform.SetParent(holder, false);
		}
		else
		{
			heroObj.transform.SetParent(transform, false);
		}

		if (heroDic == null)
		{
			heroDic = new Dictionary<int, GameObject>();
		}
		heroDic[_heroId] = heroObj;

		LoadOneHeroOver();
	}

	private void LoadOneHeroOver()
	{
		loadCounter++;
		if (loadCounter >= needLoadCounter)
		{
			loaded = true;
			Reposition();
			AllLoadOverCallBack?.Invoke();
		}
	}

	public bool Steal(int cfg, out GameObject spine)
	{
		spine = null;
		return false;
	}

	public void Return()
	{
	}
}
