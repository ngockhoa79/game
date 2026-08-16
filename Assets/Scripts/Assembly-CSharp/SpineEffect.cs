using SpineWWW.Unity;
using UnityEngine;

public class SpineEffect : MonoBehaviour
{
	public enum AnimType
	{
		skill = 0,
		skill_0 = 1,
		skill_1 = 2,
		skill_2 = 3,
		action = 101
	}

	public SpineWWW.Unity.SkeletonAnimation anim;

	public AnimType type;

	public bool loop;

	[Header("延迟销毁")]
	public float delayDestroy;

	private void Start()
	{
	}

	public string GetAnimName()
	{
		return null;
	}
}
