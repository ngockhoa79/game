using System;
using SpineWWW.Unity;
using UnityEngine;

public class SpineEffectGroup : MonoBehaviour
{
	[Serializable]
	private class EffectGroup
	{
		public string animName;

		public float delay;

		public bool loop;
	}

	[SerializeField]
	private SpineWWW.Unity.SkeletonAnimation anim;

	[Space]
	[SerializeField]
	private bool isLeft;

	[SerializeField]
	private EffectGroup[] effectGroups;

	[Header("延迟销毁时间")]
	public float delayDestroy;

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
