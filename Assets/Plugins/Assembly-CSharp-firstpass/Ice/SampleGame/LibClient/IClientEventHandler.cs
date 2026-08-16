using System.Net.Sockets;

namespace Ice.SampleGame.LibClient
{
	public interface IClientEventHandler
	{
		void OnConnected();

		void OnDisconnected(ConnectionStatus status, SocketError errorCode);

		void OnError(int err);

		void OnLoginByAuthTokenAck(LoginByAuthTokenResoult code, string sessionToken);

		void OnLoginBySessionTokenAck(LoginBySessionTokenResoult code, string sessionToken);

		void OnMessage(object msg, int msgId);
	}
}
