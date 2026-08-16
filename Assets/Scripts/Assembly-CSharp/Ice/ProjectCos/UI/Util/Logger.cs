using System;
using UnityEngine;

namespace Ice.ProjectCos.UI.Util
{
	public class Logger
	{
		public string Name { get; private set; }

		public Logger(string name = "")
		{
			Name = name;
		}

		public Logger(Type type)
		{
			Name = type != null ? type.Name : "";
		}

		public void Debug(string msg, params object[] args)
		{
			UnityEngine.Debug.Log($"[{Name}] {string.Format(msg, args)}");
		}

		public void Info(string msg, params object[] args)
		{
			UnityEngine.Debug.Log($"[{Name}] {string.Format(msg, args)}");
		}

		public void Warn(string msg, params object[] args)
		{
			UnityEngine.Debug.LogWarning($"[{Name}] {string.Format(msg, args)}");
		}

		public void Error(string msg, params object[] args)
		{
			UnityEngine.Debug.LogError($"[{Name}] {string.Format(msg, args)}");
		}
	}
}
