using ProtoBuf;

public static class NetTools
{
	public static byte[] ToByteArray(this IExtensible proto)
	{
		return null;
	}

	public static T ToProtoClass<T>(this byte[] buff) where T : class, IExtensible
	{
		return null;
	}
}
