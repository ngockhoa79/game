using System;
using System.Collections;
using UnityEngine;

public class Defer
{
	private static UVTemp runner;

	public static UVTemp getRunner()
	{
		if (runner == null)
		{
			GameObject gameObject = new GameObject("UVTemp");
			if (Application.isPlaying)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			runner = gameObject.AddComponent<UVTemp>();
		}
		return runner;
	}

	public static void Frames(int frameCount, Action task)
	{
		if (getRunner() != null)
		{
			getRunner().StartCoroutine(deferFrames(frameCount, task));
		}
	}

	private static IEnumerator deferFrames(int frameCount, Action task)
	{
		for (int i = 0; i < frameCount; i++)
		{
			yield return null;
		}
		task?.Invoke();
	}

	public static void Seconds(float seconds, Action task)
	{
		if (getRunner() != null)
		{
			getRunner().StartCoroutine(deferSeconds(seconds, task));
		}
	}

	private static IEnumerator deferSeconds(float seconds, Action task)
	{
		yield return new WaitForSeconds(seconds);
		task?.Invoke();
	}
}
