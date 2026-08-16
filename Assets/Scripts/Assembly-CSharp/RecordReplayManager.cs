using System.Collections.Generic;
using UnityEngine;

public class RecordReplayManager : MonoBehaviour
{
	[HideInInspector]
	public List<BattleReportInfo> RecordReportsList { get; private set; }

	public void SetRecordReports(List<byte[]> reports)
	{
	}
}
