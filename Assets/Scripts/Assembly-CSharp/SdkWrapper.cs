using System.Collections.Generic;

public static class SdkWrapper
{
	private static string STATIS_UMENG;

	private static string STATIS_MBI;

	private static string STATIS_TESSAR;

	public static void SetAlwaysAwake(bool isAlwaysAwake)
	{
	}

	public static void Startup()
	{
	}

	public static void ShowToolBar(bool bShow)
	{
	}

	public static void logout()
	{
	}

	public static void LoginWithServer(string server_id, string server_name, string userId, string userName, int level, bool isAppstore, string secretKey)
	{
	}

	public static void Logout()
	{
	}

	public static void GetBulletinList()
	{
	}

	public static void UpdateClient(string version, string content, string url)
	{
	}

	public static string GetChannelID()
	{
		return null;
	}

	public static void StatisticConsume(int gold, int crystal, int transformSoul)
	{
	}

	public static void StatisticPlayerLevelInfo(int level)
	{
	}

	public static void StatisticLoginServer(string idStr)
	{
	}

	public static void StatisticSetRoleName(string roleName)
	{
	}

	public static void StatisticSetLevel(int level)
	{
	}

	private static void statisticWithEventAndParameters(string eventId, Dictionary<string, string> parameters, string sdk)
	{
	}

	public static string GetAId()
	{
		return null;
	}

	public static void OnUnityStart()
	{
	}

	public static bool showCustomerService()
	{
		return false;
	}

	public static bool ShowBindMobile()
	{
		return false;
	}

	public static void CallBindMobile(string value)
	{
	}

	public static void ComitToken(string value, string Phone)
	{
	}
}
