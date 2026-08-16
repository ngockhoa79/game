using System.Collections.Generic;
using Foundation;
using UnityEngine;

public class AudioBundlesList
{
	private class AudioBundleContent
	{
		public AudioClip audioClip;

		public float progress;

		public bool bLoadComplete;

		public void Clear()
		{
		}
	}

	private Dictionary<string, AudioBundleContent> _audioBundleList;

	public void SetProgress(string loadResourceType, string audioName, float progress)
	{
	}

	public bool GetProgress(string loadResourceType, string audioName, out float progress)
	{
		progress = default(float);
		return false;
	}

	public void LoadComplete(string loadResourceType, string audioName, AudioClip audioClip)
	{
	}

	public bool LoadAudioClip(string loadResourceType, string audioName, out AudioClip audioClip)
	{
		audioClip = null;
		return false;
	}

	public bool Unload(string audioName, string loadResourceType)
	{
		return false;
	}

	public void UnloadAll()
	{
	}

	private string GetAudioKey(string loadResourceType, string audioName)
	{
		return null;
	}

	public List<Tuple<string, string, float>> GetAllProgress()
	{
		return null;
	}
}
