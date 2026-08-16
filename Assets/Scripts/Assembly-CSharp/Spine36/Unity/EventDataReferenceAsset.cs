using UnityEngine;

namespace Spine36.Unity
{
	[CreateAssetMenu(menuName = "Spine/EventData Reference Asset")]
	public class EventDataReferenceAsset : ScriptableObject
	{
		private const bool QuietSkeletonData = true;

		[SerializeField]
		protected SkeletonDataAsset skeletonDataAsset;

		[SpineEvent(null, "skeletonDataAsset", true, false)]
		[SerializeField]
		protected string eventName;

		private EventData eventData;

		public EventData EventData => null;

		public void Initialize()
		{
		}

		public static implicit operator EventData(EventDataReferenceAsset asset)
		{
			return null;
		}
	}
}
