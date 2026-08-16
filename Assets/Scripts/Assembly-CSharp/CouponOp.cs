using Ice.ProjectCos.UI.GameOperations;

public class CouponOp : Operation
{
	private string couponCode;

	public CouponOp(string code)
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
