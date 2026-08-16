using System.Collections.Generic;

namespace Spine
{
	public class Skin
	{
		private class AttachmentComparer : IEqualityComparer<KeyValuePair<int, string>>
		{
			internal static readonly AttachmentComparer Instance;

			bool IEqualityComparer<KeyValuePair<int, string>>.Equals(KeyValuePair<int, string> o1, KeyValuePair<int, string> o2)
			{
				return false;
			}

			int IEqualityComparer<KeyValuePair<int, string>>.GetHashCode(KeyValuePair<int, string> o)
			{
				return 0;
			}
		}

		internal string name;

		private Dictionary<KeyValuePair<int, string>, Attachment> attachments;

		public Dictionary<KeyValuePair<int, string>, Attachment> Attachments => null;

		public string Name => null;

		public Skin(string name)
		{
		}

		public Skin()
		{
		}

		public void AddAttachment(int slotIndex, string name, Attachment attachment)
		{
		}

		public Attachment GetAttachment(int slotIndex, string name)
		{
			return null;
		}

		public void FindNamesForSlot(int slotIndex, List<string> names)
		{
		}

		public void FindAttachmentsForSlot(int slotIndex, List<Attachment> attachments)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal void AttachAll(Skeleton skeleton, Skin oldSkin)
		{
		}
	}
}
