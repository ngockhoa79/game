using System;
using System.Net.Sockets;
using Ice.LibClient.Protocol;
using Ice.Project.Utils;

namespace Ice.SampleGame.LibClient
{
	public class Client
	{
		private enum ADDRESSFAM
		{
			IPv4 = 0,
			IPv6 = 1
		}

		private sealed class ReceiveStateObject
		{
			public ArraySegment<byte> Buffer;

			public int BytesLeft;
		}

		private sealed class SendStateObject
		{
			public ArraySegment<byte> Buffer;
		}

		private sealed class ErrorOnDataResultException : Exception
		{
			public ErrorOnDataResultException(int bytesHandled, int bytesLeft)
			{
			}
		}

		private const int ReceiveBufferSize = 262144;

		private const int SendBufferSize = 4096;

		private AsynchronousSocket socket_;

		protected IProtoProvider provider_;

		protected Action<Action> postAction_;

		private object closelockObj_;

		private bool isCloseCalled;

		public bool IsConnected => false;

		public bool IsClosed => false;

		private string GetIPv6(string host)
		{
			return null;
		}

		private void GetIPType(string serverIp, out string newServerIp, out AddressFamily IPType)
		{
			newServerIp = null;
			IPType = default(AddressFamily);
		}

		private string GetIPAddress(string hostName, ADDRESSFAM AF)
		{
			return null;
		}

		private bool IsIPAddress(string data)
		{
			return false;
		}

		public Client(Action<Action> postAction)
		{
		}

		public bool StartConnect(string host, int port)
		{
			return false;
		}

		private void ConnectCallback(IAsyncResult ar)
		{
		}

		protected virtual void OnConnected()
		{
		}

		protected virtual void OnReceiveMessage(object message)
		{
		}

		protected virtual void OnDisconnected(SocketError errorCode)
		{
		}

		private SocketError GetSocketError(Exception e)
		{
			return default(SocketError);
		}

		private void CloseSocket(SocketError errorCode)
		{
		}

		public void Close()
		{
		}

		private void StartReceive()
		{
		}

		private void StartReceive(ReceiveStateObject receiveStateObject)
		{
		}

		private void StartReceiveCallback(IAsyncResult ar)
		{
		}

		private int OnData(ArraySegment<byte> buffer)
		{
			return 0;
		}

		public bool SendAsyc(object msg)
		{
			return false;
		}

		private bool StartSend(SendStateObject sendStateObject)
		{
			return false;
		}

		private void SendCallback(IAsyncResult ar)
		{
		}
	}
}
