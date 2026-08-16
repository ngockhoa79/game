using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadingUI : MonoBehaviour
{
	public enum LoadingUIType
	{
		FlashLoadingUI = 0,
		ShowPercentLoadingUI = 1
	}

	public enum LoadingUIProgressType
	{
		None = 0,
		LoadingScene = 1,
		LoadingResources = 2,
		BuildingScene = 3
	}

	private const float _RATIO_LOADING_SCENE_ = 0.7f;

	private const float _RATIO_LOADING_RESOURCES_ = 0.1f;

	private const float _RATIO_LOADING_BUILD_SCENE = 0.2f;

	public GameObject loadingUIRoot;

	public IceAnimatorTotalCommander load_in;

	public IceAnimatorTotalCommander load_out;

	public GameObject npc_root;

	public UILabel lbTips;

	private Action E_OnBeginLoad;

	private GameObject npc_animation;

	private bool bStartLoading;

	private LoadingUIType _curLoadingType;

	private LoadingUIProgressType _curProgressType;

	private Dictionary<LoadingUIProgressType, float> _loadingProgress;

	private Dictionary<string, List<string>> _toLoadFromUrl;

	private Dictionary<string, List<string>> _toLoadFromLocal;

	private const int LoadingSceneWeight = 2000;

	private const int LoadingResourcesWeight = 7000;

	private const int BuildingSceneWeight = 1000;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ShowLoadingUI(Action onCallBack, LoadingUIType loadingType = LoadingUIType.FlashLoadingUI)
	{
	}

	private void SetNpcAnimation(GameObject go)
	{
	}

	public void HideLoadingUI()
	{
	}

	public void SetLoadingSceneProgress(float ratio)
	{
	}

	public void SetBuildingSceneProgress(float ratio)
	{
	}

	public void RegistResourcesLoadList(Dictionary<string, List<string>> urlList, Dictionary<string, List<string>> localList)
	{
	}

	public void UnRegistResourcesLoadList()
	{
	}

	private void internal_start()
	{
	}

	private void internal_finish()
	{
	}

	private void CalculateLoadingResourcesProgress()
	{
	}

	private void SetProgressAnimation(float ratio)
	{
	}

	private float GetCurProgress()
	{
		return 0f;
	}
}
