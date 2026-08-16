using System;
using System.IO;
using System.Threading;

namespace Simias.Encryption
{
	public class BlowfishStream : Stream
	{
		private class CBState : IAsyncResult
		{
			internal AsyncCallback callback;

			internal object state;

			internal byte[] buffer;

			internal IAsyncResult result;

			public object AsyncState => null;

			public bool CompletedSynchronously => false;

			public WaitHandle AsyncWaitHandle => null;

			public bool IsCompleted => false;

			internal CBState(AsyncCallback callback, object state, byte[] buffer)
			{
			}
		}

		public enum Target
		{
			Encrypted = 0,
			Normal = 1
		}

		private Stream stream;

		private Blowfish bf;

		private Target target;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		private BlowfishStream(Stream stream, Blowfish bf, Target target)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		private void ReadComplete(IAsyncResult result)
		{
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}
	}
}
