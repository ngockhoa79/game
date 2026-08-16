using UnityEngine;

namespace Spine36.Unity
{
	public struct SubmeshInstruction
	{
		public Skeleton skeleton;

		public int startSlot;

		public int endSlot;

		public Material material;

		public bool forceSeparate;

		public int preActiveClippingSlotSource;

		public int rawTriangleCount;

		public int rawVertexCount;

		public int rawFirstVertexIndex;

		public bool hasClipping;

		public int SlotCount => 0;

		public override string ToString()
		{
			return null;
		}
	}
}
