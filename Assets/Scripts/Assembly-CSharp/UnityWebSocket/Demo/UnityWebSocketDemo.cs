using UnityEngine;

namespace UnityWebSocket.Demo
{
	public class UnityWebSocketDemo : MonoBehaviour
	{
		public string address;

		public string sendText;

		private IWebSocket socket;

		private bool logMessage;

		private string log;

		private int sendCount;

		private int receiveCount;

		private Vector2 scrollPos;

		private Color green;

		private Color red;

		private Color wait;

		private int frame;

		private float time;

		private float fps;

		private void OnGUI()
		{
		}

		private void AddLog(string str)
		{
		}

		private void Socket_OnOpen(object sender, OpenEventArgs e)
		{
		}

		private void Socket_OnMessage(object sender, MessageEventArgs e)
		{
		}

		private void Socket_OnClose(object sender, CloseEventArgs e)
		{
		}

		private void Socket_OnError(object sender, ErrorEventArgs e)
		{
		}

		private void Update()
		{
		}
	}
}
