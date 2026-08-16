using System;

namespace Ice.LibClient.Protocol
{
	public class CCMSGConnectionRecvFailure
	{
		public int MessageId => 0;

		public Exception ExceptionInfo { get; set; }
	}
}
