using System;

namespace Ice.LibClient.Protocol
{
	public interface IProtoProvider
	{
		Type GetTypeById(int vId);

		int GetIdByType(Type vType);
	}
}
