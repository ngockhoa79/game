using Spine;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Spine/BoneComponent")]
public class BoneComponent : MonoBehaviour
{
	public SkeletonComponent skeletonComponent;

	public Bone bone;

	public string boneName;

	protected Transform cachedTransform;

	protected Transform skeletonComponentTransform;

	private void Awake()
	{
	}

	public void LateUpdate()
	{
	}
}
