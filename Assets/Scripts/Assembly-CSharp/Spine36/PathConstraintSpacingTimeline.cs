namespace Spine36
{
	public class PathConstraintSpacingTimeline : PathConstraintPositionTimeline
	{
		public override int PropertyId => 0;

		public PathConstraintSpacingTimeline(int frameCount)
			: base(0)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction)
		{
		}
	}
}
