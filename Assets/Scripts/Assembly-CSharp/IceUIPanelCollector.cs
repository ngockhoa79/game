using System;
using System.Collections.Generic;
using UnityEngine;

public class IceUIPanelCollector : MonoBehaviour
{
	[Serializable]
	public class Entry
	{
		public string Name;

		public UIPanel Panel;
	}

	private int _counter;

	[SerializeField]
	private List<Entry> entries = new List<Entry>();

	public T GetPanel<T>(string name) where T : Component
	{
		UIPanel panel = GetPanel(name);
		if (panel != null)
		{
			return panel.GetComponent<T>();
		}
		return null;
	}

	public T GetPanel<T>() where T : Component
	{
		return GetPanel<T>(typeof(T).Name);
	}

	public UIPanel GetPanel(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}

		if (entries != null)
		{
			for (int i = 0; i < entries.Count; i++)
			{
				Entry entry = entries[i];
				if (entry != null && string.Equals(entry.Name, name, StringComparison.Ordinal))
				{
					return entry.Panel;
				}
			}
		}

		Debug.LogWarning($"[IceUIPanelCollector] Panel with name '{name}' not found in collector.");
		return null;
	}

	public bool TryGetPanel(string name, out UIPanel panel)
	{
		if (string.IsNullOrEmpty(name))
		{
			panel = null;
			return false;
		}

		if (entries != null)
		{
			for (int i = 0; i < entries.Count; i++)
			{
				Entry entry = entries[i];
				if (entry != null && string.Equals(entry.Name, name, StringComparison.Ordinal))
				{
					panel = entry.Panel;
					return true;
				}
			}
		}

		panel = null;
		return false;
	}

	public void RegistPanel(string name, UIPanel panel)
	{
		if (string.IsNullOrEmpty(name) || panel == null)
		{
			return;
		}

		if (entries == null)
		{
			entries = new List<Entry>();
		}

		for (int i = 0; i < entries.Count; i++)
		{
			Entry entry = entries[i];
			if (entry != null && string.Equals(entry.Name, name, StringComparison.Ordinal))
			{
				entry.Panel = panel;
				return;
			}
		}

		entries.Add(new Entry
		{
			Name = name,
			Panel = panel
		});
	}

	public bool UnregistPanel(string name)
	{
		if (string.IsNullOrEmpty(name) || entries == null)
		{
			return false;
		}

		for (int i = 0; i < entries.Count; i++)
		{
			Entry entry = entries[i];
			if (entry != null && string.Equals(entry.Name, name, StringComparison.Ordinal))
			{
				entries.RemoveAt(i);
				return true;
			}
		}

		return false;
	}
}
