using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class MailItemInfo
	{
		private MailAttachmentsClient mAttchments;

		private MailItemProto mMailInfoProto;

		public MailAttachmentsClient Attachs => null;

		public int ID { get; set; }

		public int Type { get; set; }

		public string SenderName { get; set; }

		public string SendTime { get; set; }

		public string Title { get; set; }

		public string Text { get; set; }

		public bool IsRead { get; set; }

		public bool IsAwardGot { get; set; }

		public MailCategory Catalog { get; set; }

		public void CreateFormDetailInfo(MailItemProto info)
		{
		}

		public void MarkAsRead()
		{
		}

		public void MarkAsAttachGot()
		{
		}

		public bool HasAttachment()
		{
			return false;
		}

		public bool IsMailOutOfDate()
		{
			return false;
		}

		public bool IsNeedDelete()
		{
			return false;
		}
	}
}
