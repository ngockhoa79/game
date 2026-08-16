using System;
using System.Net.Sockets;
using System.Threading;

namespace Ice.Project.Utils
{
	public sealed class AsynchronousSocket
	{
		private sealed class AsynchronousAsyncResult : IAsyncResult
		{
			private object state_;

			public Exception Exception { get; private set; }

			public int BytesTransferred { get; private set; }

			public object AsyncState => null;

			public WaitHandle AsyncWaitHandle => null;

			public bool CompletedSynchronously => false;

			public bool IsCompleted => false;

			public AsynchronousAsyncResult(object state)
			{
			}

			public AsynchronousAsyncResult(object state, int bytesTransferred)
			{
			}

			public AsynchronousAsyncResult(object state, Exception exception)
			{
			}
		}

		private Socket socket_;

		private EventThreadLooper looperOfSendAndConnect_;

		private EventThreadLooper looperOfReceive_;

		public bool Connected => false;

		public AsynchronousSocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
		}

		public void BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
		}

		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		public void BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
		}

		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		public void BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
		}

		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		private void HanderEvent(object message)
		{
		}

		public void Shutdown(SocketShutdown how)
		{
		}

		public void Close()
		{
		}
	}
}
