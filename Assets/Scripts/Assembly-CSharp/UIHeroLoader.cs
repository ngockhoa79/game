using System;
using Spine36.Unity;
using SpineWWW.Unity;
using UnityEngine;

public class UIHeroLoader : MonoBehaviour
{
	public Action<bool> E_OnInitialized;

	public static int _heroId;

	private bool _bDisplayShadow;

	private float _shadowDistance;

	private string bundleName;

	private string[] init_animations;

	private Shader _shader;

	public GameObject TargetObject;

	private Vector3 initScale_character;

	private Vector3 initScale_shadow;

	public SkeletonAnimation sa;

	public SpineWWW.Unity.SkeletonAnimation saNew;

	public Spine36.Unity.SkeletonAnimation sa36;

	private Transform shadowGo;

	private bool bDestroyed;

	public static bool bNeedInstantiate;

	public void SetHero(int heroId, bool bDisplayShadow = true, float shadowDistance = 10f, Shader shader = null, bool needScreenBlocker = true)
	{
	}

	private void LoadCallback(string category, string identifier, UnityEngine.Object go, bool screenBlocker)
	{
	}

	public void Clear()
	{
	}

	private void OnDestroy()
	{
	}
}
