using System.Collections.Generic;

namespace Spine
{
	public class NewSkeletonJson
	{
		private class AnimationPosContent
		{
			public float Time;

			public float X;

			public float Y;

			public CurveType CurveType;

			public float Curve1;

			public float Curve2;

			public float Curve3;

			public float Curve4;

			private int SetCurveIndex;

			public void SetCurve(float curve)
			{
			}
		}

		public enum CurveType
		{
			Linear = 0,
			Curve = 1,
			Stepped = 2
		}

		private class AnimationRotContent
		{
			public float Time;

			public float Angle;

			public CurveType CurveType;

			public float Curve1;

			public float Curve2;

			public float Curve3;

			public float Curve4;

			private int SetCurveIndex;

			public void SetCurve(float curve)
			{
			}
		}

		private class AnimationSlotContent
		{
			public float Time;

			public string NameOrColor;
		}

		private class AnimationDrawOrderContent
		{
			public float Time;

			public List<AnimationDrawOrderOffset> OffsetList;

			public void Clear()
			{
			}
		}

		private class AnimationDrawOrderOffset
		{
			public int SlotIndex;

			public float Offsets;
		}

		private object obj;

		private object obj2;

		private float animation_duration;

		private int animation_draworder_slotCount;

		private int animation_boneIndex;

		private int animation_slotIndex;

		public float Scale { get; set; }

		public void ReadSkeletonData(SkeletonJsonData skeletonJsonData, string reader)
		{
		}

		public void ReadSkeletonDataFinished(SkeletonJsonData skeletonJsonData)
		{
		}

		private void ProcessStartObject(SkeletonJsonData skeletonJsonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessReadObject(SkeletonJsonData skeletonJsonData, string[] propertyStack, int propertyIndex, string content)
		{
		}

		private void ProcessEndObject(SkeletonJsonData skeletonJsonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessStartArray(SkeletonJsonData skeletonJsonData, string[] propertyStack, int propertyIndex)
		{
		}

		private void ProcessEndArray(SkeletonJsonData skeletonJsonData, string[] propertyStack, int propertyIndex)
		{
		}

		private float GetFloat(Dictionary<string, object> map, string name, float defaultValue)
		{
			return 0f;
		}

		private int GetInt(Dictionary<string, object> map, string name, int defaultValue)
		{
			return 0;
		}

		private bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue)
		{
			return false;
		}

		private string GetString(Dictionary<string, object> map, string name, string defaultValue)
		{
			return null;
		}

		public static float ToColor(string hexString, int colorIndex)
		{
			return 0f;
		}

		private void ReadAnimation(string name, Dictionary<string, object> map, SkeletonJsonData skeletonJsonData)
		{
		}

		private void ReadCurve(CurveTimeline timeline, int frameIndex, Dictionary<string, object> valueMap)
		{
		}
	}
}
