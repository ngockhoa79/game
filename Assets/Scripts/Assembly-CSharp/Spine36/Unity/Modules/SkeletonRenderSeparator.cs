using System.Collections.Generic;
using UnityEngine;

namespace Spine36.Unity.Modules
{
	[HelpURL("https://github.com/pharan/spine-unity-docs/blob/master/SkeletonRenderSeparator.md")]
	[ExecuteInEditMode]
	public class SkeletonRenderSeparator : MonoBehaviour
	{
		public const int DefaultSortingOrderIncrement = 5;

		[SerializeField]
		protected SkeletonRenderer skeletonRenderer;

		private MeshRenderer mainMeshRenderer;

		public bool copyPropertyBlock;

		[Tooltip("Copies MeshRenderer flags into each parts renderer")]
		public bool copyMeshRendererFlags;

		public List<SkeletonPartsRenderer> partsRenderers;

		private MaterialPropertyBlock copiedBlock;

		public SkeletonRenderer SkeletonRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = true)
		{
			return null;
		}

		public void AddPartsRenderer(int sortingOrderIncrement = 5)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleRender(SkeletonRendererInstruction instruction)
		{
		}
	}
}
