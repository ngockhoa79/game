namespace Spine36.Unity
{
	public interface ISkeletonAnimation
	{
		Skeleton Skeleton { get; }

		event UpdateBonesDelegate UpdateLocal;

		event UpdateBonesDelegate UpdateWorld;

		event UpdateBonesDelegate UpdateComplete;
	}
}
