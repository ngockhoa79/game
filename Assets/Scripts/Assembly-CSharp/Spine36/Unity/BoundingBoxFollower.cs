using System.Collections.Generic;
using UnityEngine;

namespace Spine36.Unity
{
	[ExecuteInEditMode]
	public class BoundingBoxFollower : MonoBehaviour
	{
		internal static bool DebugMessages;

		public SkeletonRenderer skeletonRenderer;

		[SpineSlot(null, "skeletonRenderer", true, true, false)]
		public string slotName;

		public bool isTrigger;

		public bool clearStateOnDisable;

		private Slot slot;

		private BoundingBoxAttachment currentAttachment;

		private string currentAttachmentName;

		private PolygonCollider2D currentCollider;

		public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable;

		public readonly Dictionary<BoundingBoxAttachment, string> nameTable;

		public Slot Slot => null;

		public BoundingBoxAttachment CurrentAttachment => null;

		public string CurrentAttachmentName => null;

		public PolygonCollider2D CurrentCollider => null;

		public bool IsTrigger => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleRebuild(SkeletonRenderer sr)
		{
		}

		public void Initialize(bool overwrite = false)
		{
		}

		private void AddSkin(Skin skin, int slotIndex)
		{
		}

		private void OnDisable()
		{
		}

		public void ClearState()
		{
		}

		private void DisposeColliders()
		{
		}

		private void LateUpdate()
		{
		}

		private void MatchAttachment(Attachment attachment)
		{
		}
	}
}
