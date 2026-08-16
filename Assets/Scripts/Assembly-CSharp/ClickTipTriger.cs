using UnityEngine;

public class ClickTipTriger : TipTriger
{
	private bool mIsPopOut;

	public ClickTipTriger(UIEventListener triger, TipDelegate callback)
		: base(null, null)
	{
	}

	public override void BindEvent()
	{
	}

	public override void UnBindEvent()
	{
	}

	public void OnClick(GameObject go)
	{
	}
}
