public class AutoTipTriger : TipTriger
{
	public enum AutoTrigerType
	{
		PressTriger = 0,
		ClickTriger = 1
	}

	public static AutoTrigerType UsingAutoTrigerType;

	protected TipTriger mRealTriger;

	public AutoTipTriger(UIEventListener triger, TipDelegate callback)
		: base(null, null)
	{
	}

	public override void BindEvent()
	{
	}

	public override void UnBindEvent()
	{
	}

	public override void Clear()
	{
	}
}
