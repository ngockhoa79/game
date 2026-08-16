using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.GameOperations;

public class BatchHeirloomOperation : Operation
{
	private Hero destination;

	private int[] skills;

	private int[] gears;

	public BatchHeirloomOperation(Hero card, int[] skills, int[] gears)
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
