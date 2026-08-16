using UnityEngine;

namespace Spine36.Unity.Modules
{
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class SkeletonPartsRenderer : MonoBehaviour
	{
		private MeshGenerator meshGenerator;

		private MeshRenderer meshRenderer;

		private MeshFilter meshFilter;

		private MeshRendererBuffers buffers;

		private SkeletonRendererInstruction currentInstructions;

		public MeshGenerator MeshGenerator => null;

		public MeshRenderer MeshRenderer => null;

		public MeshFilter MeshFilter => null;

		private void LazyIntialize()
		{
		}

		public void ClearMesh()
		{
		}

		public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
		{
		}

		public void SetPropertyBlock(MaterialPropertyBlock block)
		{
		}

		public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name)
		{
			return null;
		}
	}
}
