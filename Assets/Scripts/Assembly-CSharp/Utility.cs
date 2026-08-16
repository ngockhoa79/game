using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public static class Utility
{
	public const int DefaultCharPerLine = 20;

	public static readonly DateTime UnixBaseDateTime;

	private static int localStartTime_;

	private static bool bInitServerTime;

	public static int NowTimestamp => 0;

	public static DateTime StartGameTime { get; private set; }

	public static int TimeZoneRawOffset { get; private set; }

	public static bool InitServerTime => false;

	public static bool IsInitedServerTimeInfo => false;

	public static DateTime CurDateTime => default(DateTime);

	public static string F(this string s, params object[] args)
	{
		return null;
	}

	public static bool IsCorrectIndex<T>(this IList<T> list, int index)
	{
		return false;
	}

	public static bool IsNullOrEmpty<T>(this IList<T> list)
	{
		return false;
	}

	public static T GetOrDefault<T>(this IList<T> list, int index, T t = default(T))
	{
		return default(T);
	}

	public static T GetOrDefault<K, T>(this IDictionary<K, T> dict, K key, T t = default(T))
	{
		return default(T);
	}

	public static T First<T>(this IList<T> list)
	{
		return default(T);
	}

	public static T Last<T>(this IList<T> list)
	{
		return default(T);
	}

	public static void AddAt<T>(this List<T> list, int index, T v)
	{
	}

	public static string ToJsonString(this IDictionary<string, string> dict)
	{
		return null;
	}

	public static int LowerBound<T>(this IList<T> list, Func<T, int> comparer)
	{
		return 0;
	}

	public static int BinarySearch<T>(this IList<T> list, Func<T, int> comparer)
	{
		return 0;
	}

	public static T BinaryFind<T>(this IList<T> list, Func<T, int> comparer)
	{
		return default(T);
	}

	public static string GetPrettyString<T>(this IEnumerable<T> l)
	{
		return null;
	}

	public static string GetPrettyString<T>(this IEnumerable<T> l, Func<T, string> func)
	{
		return null;
	}

	public static int ValueAddMultiplier(int value, int multiplier)
	{
		return 0;
	}

	public static int GetValueMultiplier(int value, int multiplier)
	{
		return 0;
	}

	public static void Swap<T>(ref T lhs, ref T rhs)
	{
	}

	public static double GetGrowValue(int lvMax, int baseValue, int maxValue, int baseLevel)
	{
		return 0.0;
	}

	public static int GetValue(int lvCur, int lvMax, int baseValue, int maxValue, int baseLevel)
	{
		return 0;
	}

	public static int GetLevelIndexFromTotal<T>(IList<T> list, Func<T, int> expfunc, int totalExp)
	{
		return 0;
	}

	public static bool TryAddValue(ref int currentValue, int addValue, int maxValue = int.MaxValue, int minValue = 0)
	{
		return false;
	}

	public static bool HasFlag(int value, int flag)
	{
		return false;
	}

	public static void SetFlag(ref int value, int flag)
	{
	}

	public static void ClearFlag(ref int value, int falg)
	{
	}

	public static long ToUnixTimestamp(this DateTime dateTime)
	{
		return 0L;
	}

	public static void SetServerTimeInfo(long unixTimestamp, int timeZoneRawOffset)
	{
	}

	public static DateTime ToLocalServerDateTime(this DateTime time)
	{
		return default(DateTime);
	}

	public static DateTime ToUtcTimeFromServerTime(this DateTime time)
	{
		return default(DateTime);
	}

	public static DateTime GetDateTime(long milliseconds)
	{
		return default(DateTime);
	}

	public static DateTime GetTodayDateTime(int hours, int minutes, int second = 0)
	{
		return default(DateTime);
	}

	public static DateTime GetDayDateTime(DateTime time, int hours, int minutes, int second = 0)
	{
		return default(DateTime);
	}

	public static DateTime GetRefreshTime(DateTime lastRefreshTime, TimeSpan refreshPoint)
	{
		return default(DateTime);
	}

	public static long GetRefreshTime(long lastRefreshTime, TimeSpan refreshPoint)
	{
		return 0L;
	}

	public static string ReplaceLine(this string s)
	{
		return null;
	}

	public static double ToDouble(this string s)
	{
		return 0.0;
	}

	public static float ToFloat(this string s)
	{
		return 0f;
	}

	public static TimeSpan ParseTimeSpan(string s)
	{
		return default(TimeSpan);
	}

	public static bool IsInRange<T>(T value, T begin, T end) where T : IComparable<T>
	{
		return false;
	}

	public static Color RGBToGrayScale(Color src)
	{
		return default(Color);
	}

	public static int GetDayOfWeekInt(DateTime d)
	{
		return 0;
	}

	public static string AutoLineSkipTag(string text, int maxCharPerLine = 20)
	{
		return null;
	}

	public static float TypeWriterDuration(string str, int charsPerSecond)
	{
		return 0f;
	}

	public static int CharBytes(this char c)
	{
		return 0;
	}

	public static bool IsSettingOn(this SettingProto settings, SettingProto.SettingEnum setting_id)
	{
		return false;
	}

	public static void TurnSettingOnOff(this SettingProto settings, SettingProto.SettingEnum setting_id, bool isOn)
	{
	}

	public static bool IsBulletinOn(this SettingProto settings)
	{
		return false;
	}

	public static void TurnBulletinOnOff(this SettingProto settings, bool isOn)
	{
	}

	public static string FormatGuildName(this PlayerSummaryInfoProto.GuildInfoProto info, UILabel lb = null)
	{
		return null;
	}

	public static string FormatGuildName(this Player.GuildEssentialInfo info, UILabel lb = null)
	{
		return null;
	}

	public static string FormatGuildName(this string n, UILabel lb = null, int icon = -1)
	{
		return null;
	}

	public static ColumnInfo.Relation Relationship(int playerID)
	{
		return default(ColumnInfo.Relation);
	}
}
