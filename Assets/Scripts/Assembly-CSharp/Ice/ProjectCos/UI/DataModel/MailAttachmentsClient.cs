using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class MailAttachmentsClient
	{
		private bool _isMonthCard;

		private List<ThingHolding> mAttachList;

		public bool IsMonthCard => false;

		public List<ThingHolding> AttachMentList => null;

		public int BattleReportID { get; private set; }

		public void ParseAttachments(List<MaillAttachmentItemProto> listAttach)
		{
		}
	}
}
