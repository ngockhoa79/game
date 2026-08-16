public abstract class TipTriger
{
	public delegate TipData TipDelegate();

	protected TipDelegate mDelegate;

	protected UIEventListener mTarger;

	public TipTriger(UIEventListener triger, TipDelegate callback)
	{
	}

	public abstract void BindEvent();

	public abstract void UnBindEvent();

	protected void PopupTip()
	{
	}

	protected void CloseTip()
	{
	}

	public virtual void Clear()
	{
	}
}
