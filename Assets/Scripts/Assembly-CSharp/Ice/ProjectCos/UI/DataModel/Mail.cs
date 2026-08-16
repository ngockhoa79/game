using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Mail
	{
		private List<MailItemInfo> mMailAll;

		private List<MailItemInfo> mMailSys;

		private List<MailItemInfo> mMailBattle;

		public List<MailItemInfo> MailListAll => null;

		public List<MailItemInfo> MailListSys => null;

		public List<MailItemInfo> MailListBattle => null;

		public void SetMailAll(List<MailItemProto> lstMails)
		{
		}

		private void addByType(MailItemInfo mi)
		{
		}

		public void RemoveMail(MailItemInfo mi)
		{
		}

		public List<MailItemInfo> GetMailListByCatalog(MailCategory ca)
		{
			return null;
		}
	}
}
