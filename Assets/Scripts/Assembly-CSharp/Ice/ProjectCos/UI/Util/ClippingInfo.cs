using UnityEngine;

namespace Ice.ProjectCos.UI.Util
{
	public class ClippingInfo
	{
		public Vector3 LocalPosition { get; private set; }

		public Vector2 ClipOffset { get; private set; }

		public Vector4 BaseClipRegion { get; private set; }

		public ClippingInfo(UIPanel Clipper)
		{
		}

		public void Set(UIPanel Clipper)
		{
		}
	}
}
