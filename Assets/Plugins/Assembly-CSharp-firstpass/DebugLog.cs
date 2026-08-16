using System.Collections.Generic;
using System.IO;

public static class DebugLog
{
	private enum DebugLogStyle
	{
		Info = 0,
		Error = 1,
		Warning = 2
	}

	private const string defaultLogType = "None";

	private static StreamWriter _debugLogSW;

	private static Dictionary<string, bool> _debugDictionary;

	private static string filename;

	private static bool _bInitialized;

	public static void TryInitialize()
	{
	}

	public static void UnInitialize()
	{
	}

	private static void CreateLogFile()
	{
	}

	private static void CloseLogFile()
	{
	}

	private static void WriteToLogFile(string content)
	{
	}

	public static void Assert(bool semantic, string message, string logType = "None")
	{
	}

	public static void Log(string content, string logType = "None")
	{
	}

	public static void LogError(string content, string logType = "None")
	{
	}

	public static void LogWarning(string content, string logType = "None")
	{
	}

	private static void WriteLog(DebugLogStyle logStyle, string logType, string content)
	{
	}

	private static bool GetNeedDebugLog(string logType)
	{
		return false;
	}

	private static void LoadDebugLogConfig(string fullFilePath)
	{
	}

	private static void SaveDebugLogConfig(string fullFilePath)
	{
	}

	private static void MakeDebugDictionaryCompletely()
	{
	}
}
