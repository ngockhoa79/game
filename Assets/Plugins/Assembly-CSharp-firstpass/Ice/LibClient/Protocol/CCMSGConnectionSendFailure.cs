using System;

namespace Ice.LibClient.Protocol
{
	public class CCMSGConnectionSendFailure
	{
		public int MessageId => 0;

		public Exception ExceptionInfo { get; set; }
	}
}
