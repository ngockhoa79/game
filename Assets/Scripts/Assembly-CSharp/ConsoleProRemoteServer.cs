using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class ConsoleProRemoteServer : MonoBehaviour
{
	public class HTTPContext
	{
		public HttpListenerContext context;

		public string path;

		public string Command => null;

		public HttpListenerRequest Request => null;

		public HttpListenerResponse Response => null;

		public HTTPContext(HttpListenerContext inContext)
		{
		}

		public void RespondWithString(string inString)
		{
		}
	}

	public class QueuedLog
	{
		public string message;

		public string stackTrace;

		public LogType type;
	}

	public int port;

	private static HttpListener listener;

	private static List<QueuedLog> logs;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void LogCallback(string logString, string stackTrace, LogType type)
	{
	}

	private static void QueueLog(string logString, string stackTrace, LogType type)
	{
	}

	private void ListenerCallback(IAsyncResult result)
	{
	}

	private void HandleRequest(HTTPContext context)
	{
	}
}
