using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class OpActivity
	{
		private Dictionary<int, DateTime> openInfos;

		private int _growingIndexMark;

		private int _grandTotalIndexMark;

		public OperateProto.OpenServerActivityProto OpenServerInfo;

		public Dictionary<int, DateTime> OpenInfos => null;

		public int GrowingIndexMark => 0;

		public int GrandTotalIndexMark => 0;

		public int GrandTotalCount { get; set; }

		public void Reload()
		{
		}

		public void LoadFromProto(OperateProto proto)
		{
		}

		public void LoadFromInfoProto(S2COperateOpenNtf ntf)
		{
		}

		public List<int> GetAvailableActivityId()
		{
			return null;
		}

		public bool CheckShowRedDot()
		{
			return false;
		}

		public void ShowRedDot()
		{
		}

		public bool GetGrowGotByIndex(int index)
		{
			return false;
		}

		public void SynchronizeGrowMask(int growmask)
		{
		}

		public bool GetGrandTotalGotByIndex(int index)
		{
			return false;
		}

		public void SynchronizeGrandTotalMask(int growmask)
		{
		}
	}
}
