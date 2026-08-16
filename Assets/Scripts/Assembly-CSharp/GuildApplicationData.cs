using Ice.ProjectCos.UI.DataModel;

public class GuildApplicationData
{
	public enum ApplicationItemState
	{
		Buttons = 0,
		AlreadyConfirmed = 1,
		AlreadyRefused = 2
	}

	public Friend Applicant;

	public long ApplyTime;

	public ApplicationItemState State;
}
