namespace Spine36
{
	public class ShearTimeline : TranslateTimeline
	{
		public override int PropertyId => 0;

		public ShearTimeline(int frameCount)
			: base(0)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction)
		{
		}
	}
}
