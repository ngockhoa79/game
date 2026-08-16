using Ice.ProjectCos.UI.DataModel;

public class UIBulletinMessage : IceUIBase
{
	public UILabel MsgLabel;

	public float Speed;

	protected BulletinMessage contentData;

	private void Update()
	{
	}

	public int GetLength()
	{
		return 0;
	}

	public void SetData(BulletinMessage data)
	{
	}
}
