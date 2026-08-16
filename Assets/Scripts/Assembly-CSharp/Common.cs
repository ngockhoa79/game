using Ice.ProjectCos.Config;
using UnityEngine;

public class Common
{
	public static string MyIP;

	public static MyServerInfo ServerInfo;

	public static MyClientVersion ClientVersion;

	public static MyNotificationInfo MyNotificationInfo;

	public static string AppDataPath => Application.dataPath;

	public static string AppPersistentDataPath => Application.persistentDataPath;

	public static string LanguageVersion;

	public static string ResourcesIp => "115.159.96.161";

	public static int ScreenWidth => Screen.width;

	public static int ScreenHeight => Screen.height;

	public static void Initiaize()
	{
	}

	public static string GetTestAuthToken(string userName)
	{
		return "test_token_" + userName;
	}

	public static string GetPersistentDataPath()
	{
		return Application.persistentDataPath;
	}

	public static string GetDownloadWritePath()
	{
		return Application.persistentDataPath + "/Download";
	}

	public static string GetDownloadReadPath()
	{
		return Application.persistentDataPath + "/Download";
	}

	public static string GetGameConfigPurePath()
	{
		return Application.streamingAssetsPath;
	}

	public static string GetGameXmlPath()
	{
		return Application.streamingAssetsPath + "/1.0/ServerInfosConfig.xml";
	}

	public static string GetPreloadReadPath()
	{
		return Application.streamingAssetsPath + "/1.0";
	}

	public static string GetBundleDownloadRootUrl()
	{
		return "http://115.159.96.161:8088/cosdld/ad20180528/";
	}

	public static string GetBundleUrl(string bundlename, string loadResourceType, string relatedPath, out bool loadFromUrl)
	{
		loadFromUrl = true;
		return GetBundleDownloadRootUrl() + bundlename;
	}

	public static string GetRealBundleName(string loadResourceType, string bundleName)
	{
		return bundleName;
	}

	public static string GetUrl(string loadResourceType, string bundleName, out string relatedPath)
	{
		relatedPath = bundleName;
		return GetBundleDownloadRootUrl() + bundleName;
	}
}

