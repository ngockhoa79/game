using Spine;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[AddComponentMenu("Spine/SkeletonAnimation")]
public class SkeletonAnimation : SkeletonComponent
{
	public delegate void UpdateBonesDelegate(SkeletonAnimation skeleton);

	private SkeletonAnimation skeletonAnimation;

	public bool loop;

	public Spine.AnimationState state;

	public UpdateBonesDelegate UpdateBones;

	public string _animationName;

	public bool bLoadUIAnimation;

	public bool bLoadBattleAnimation;

	public string animationName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Initialize()
	{
	}

	public override void UpdateSkeleton(float deltaTime)
	{
	}

	public void SetAnimation(bool bLoadUIAnimation = true, bool bLoadBattleAnimation = true, Shader shader = null)
	{
	}

	public new void OnDestroy()
	{
	}

	public static bool IsAnimationAtmainstage(string animationName)
	{
		return false;
	}
}
