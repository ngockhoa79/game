using UnityEngine;

public class PressTipTriger : TipTriger
{
	public PressTipTriger(UIEventListener triger, TipDelegate callback)
		: base(null, null)
	{
	}

	public override void BindEvent()
	{
	}

	public override void UnBindEvent()
	{
	}

	public void OnPress(GameObject go, bool bPress)
	{
	}
}
