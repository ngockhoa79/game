using System;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.GameOperations
{
	public abstract class Operation
	{
		public static Action<int, object> OnMirrorResponse;

		public static Action<int> OnMirrorFailure;

		public static Action<int> OnMirrorSent;

		private static readonly Logger logger;

		private Action<object> responseHandler;

		private Action<NetManager.CoreErrorCode> responseFailureHandler;

		private bool isNeedResponse;

		private bool bShowLoadingBlock;

		private object request;

		public int AckID { get; private set; }

		protected Operation(bool isNeedResponse, int ackID, bool bShowLoadingBlock = true)
		{
		}

		public abstract object BuildRequest();

		protected abstract void ApplyChanges(object response);

		public void Do(Action<object> onResponse, Action<object, NetManager.CoreErrorCode> onFailure)
		{
		}

		private void TrySend()
		{
		}

		private static void Send(object request, int ackID, Action<object> handler, Action<NetManager.CoreErrorCode> fail, bool _bShowLoadingBlock)
		{
		}

		public static void InvokeMirrorFailureHander(int ackId)
		{
		}
	}
}
