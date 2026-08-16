using System;
using System.Collections;
using UnityEngine;

public class UVTemp : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	new public Coroutine StartCoroutine(IEnumerator routine)
	{
		if (routine == null) return null;

		if (Application.isPlaying)
		{
			return base.StartCoroutine(routine);
		}
		else
		{
			Pump(routine);
			return null;
		}
	}

	public static void Pump(IEnumerator routine)
	{
		if (routine == null) return;
		try
		{
			int steps = 0;
			while (routine.MoveNext() && steps < 1000)
			{
				steps++;
				var current = routine.Current;
				if (current is IEnumerator nested)
				{
					Pump(nested);
				}
			}
		}
		catch (Exception ex)
		{
			DebugLog.LogError("UVTemp.Pump error: " + ex);
		}
	}
}

