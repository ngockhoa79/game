using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Fixed Alpha")]
public class UIButtonFixed : UIButtonColorFixed
{
	public static UIButtonFixed current;

	public bool dragHighlight;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public bool pixelSnap;

	public List<EventDelegate> onClick;

	private string mNormalSprite;

	private UISprite mSprite;

	public override bool isEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string normalSprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDragOver()
	{
	}

	protected override void OnDragOut()
	{
	}

	protected virtual void OnClick()
	{
	}

	protected override void SetState(State state, bool immediate)
	{
	}

	protected void SetSprite(string sp)
	{
	}
}
