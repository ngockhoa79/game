using UnityEngine;

public class IceUIToggleButton : IceUIBase
{
	public enum EState
	{
		Normal = 0,
		Selected = 1,
		Disabled = 2
	}

	private EState state;

	public GameObject Normal;

	public GameObject Selected;

	public GameObject Disabled;

	public EState ButtonState
	{
		get
		{
			return default(EState);
		}
		set
		{
		}
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void setState(EState state)
	{
	}
}
