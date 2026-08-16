using System.Collections.Generic;
using HutongGames.PlayMaker;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class FsmResManager : MonoBehaviour
{
	public enum PrefabResTask
	{
		GenPrefabResData = 0,
		SetBuffLast = 1,
		OutputBoneEffectList = 2
	}

	private class PrefabResCollection
	{
		public List<PrefabRes> resources;

		public void AddRes(string _type, string _resName)
		{
		}
	}

	private class PrefabRes
	{
		public string Type;

		public string Name;

		public PrefabRes(string _type, string _name)
		{
		}
	}

	public GameObject PrefabsNode;

	public PrefabResTask Task;

	private float timer;

	private bool loadOver;

	private Transform currentFsmTran;

	private Dictionary<string, PrefabResCollection> PrefabDic;

	private HashSet<string> heroEffects;

	private void Start()
	{
	}

	private void InitHeroEffect()
	{
	}

	private void Update()
	{
	}

	private void LoadResToScene(string _dic)
	{
	}

	private void SetEffectsTag()
	{
	}

	private void TraverseAllFsm()
	{
	}

	private void HandleFsmTran(Transform _fsmTran)
	{
	}

	private void HandleStateActionResource(FsmStateAction action)
	{
	}

	private void AddToLoadResource(string _type, string _resName)
	{
	}

	private void ExportToXml()
	{
	}

	private void SetDataForLastBuff()
	{
	}

	private void OutputBoneEffects()
	{
	}

	private List<string> GetWeaponSlots(int _gender, EHeroProfession _profession)
	{
		return null;
	}
}
