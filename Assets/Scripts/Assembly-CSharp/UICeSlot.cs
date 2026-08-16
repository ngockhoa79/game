using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICeSlot : IceUIBase
{
	public GameObject Obj;

	public UICeCardDragger Dragger;

	public UISprite Selected;

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIEventListener EventListener => null;

	public bool IsSelected
	{
		set
		{
		}
	}

	public void SwapDragger(UICeSlot another)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}
}
