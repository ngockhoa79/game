using System;
using System.Collections.Generic;
using UnityEngine;

public static class Localization
{
	public delegate byte[] LoadFunction(string path);

	public delegate void OnLocalizeNotification();

	public static LoadFunction loadFunction;

	public static OnLocalizeNotification onLocalize;

	public static bool localizationHasBeenSet;

	private static string[] mLanguages;

	private static Dictionary<string, string> mOldDictionary;

	private static Dictionary<string, string[]> mDictionary;

	private static int mLanguageIndex;

	private static string mLanguage;

	private static bool mMerging;

	public static Dictionary<string, string[]> dictionary
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string[] knownLanguages => null;

	public static string language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Localization is now always active. You no longer need to check this property.")]
	public static bool isActive => false;

	private static bool LoadDictionary(string value)
	{
		return false;
	}

	private static bool LoadAndSelect(string value)
	{
		return false;
	}

	public static void Load(TextAsset asset)
	{
	}

	public static void Set(string languageName, byte[] bytes)
	{
	}

	public static bool LoadCSV(TextAsset asset, bool merge = false)
	{
		return false;
	}

	public static bool LoadCSV(byte[] bytes, bool merge = false)
	{
		return false;
	}

	private static bool HasLanguage(string languageName)
	{
		return false;
	}

	private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false)
	{
		return false;
	}

	private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
	}

	private static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		return null;
	}

	private static bool SelectLanguage(string language)
	{
		return false;
	}

	public static void Set(string languageName, Dictionary<string, string> dictionary)
	{
	}

	public static void Set(string key, string value)
	{
	}

	public static string Get(string key)
	{
		return null;
	}

	public static string Format(string key, params object[] parameters)
	{
		return null;
	}

	[Obsolete("Use Localization.Get instead")]
	public static string Localize(string key)
	{
		return null;
	}

	public static bool Exists(string key)
	{
		return false;
	}
}
