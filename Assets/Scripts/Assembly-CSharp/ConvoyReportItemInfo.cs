public class ConvoyReportItemInfo
{
	public int heroID { get; set; }

	public string name { get; set; }

	public int vip { get; set; }

	public string guildName { get; set; }

	public int level { get; set; }

	public bool isWin { get; set; }

	public int reportID { get; set; }

	public string carName { get; set; }

	public long happenTime { get; set; }

	public int failPunish { get; set; }

	public bool isAttacker { get; set; }

	public int headIconId { get; set; }

	public ConvoyReportItemInfo(int heroID, string name, string guildName, int level, int vip, bool isWin, int reportID, string carName, long time, int punish, bool attacker, int headIconId)
	{
	}
}
