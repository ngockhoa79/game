namespace Spine36.Unity
{
	public interface ISkeletonComponent
	{
		SkeletonDataAsset SkeletonDataAsset { get; }

		Skeleton Skeleton { get; }
	}
}
