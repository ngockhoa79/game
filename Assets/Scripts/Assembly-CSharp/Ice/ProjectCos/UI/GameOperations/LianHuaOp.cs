using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class LianHuaOp : Operation
	{
		private List<ItemHolding> _data;

		private C2SItemTransformReq.TypeEnum mType;

		public LianHuaOp(C2SItemTransformReq.TypeEnum type, List<ItemHolding> data)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
