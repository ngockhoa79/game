using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour
{
	public class Entry : IComparer<Entry>
	{
		public AbstractAnimator Animator;

		public float StartTime;

		public Entry()
		{
		}

		public Entry(AbstractAnimator animator, float startTime)
		{
		}

		public int Compare(Entry a, Entry b)
		{
			return 0;
		}
	}

	private List<Entry> animators;

	public bool AutoPlay;

	private long startTime;

	private int nextEntryIdx;

	public Entry Add(AbstractAnimator animator, float startTime)
	{
		return null;
	}

	public void Play()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void Stop()
	{
	}

	private void Animate()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
