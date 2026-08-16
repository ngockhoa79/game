using System;
using System.Runtime.CompilerServices;

public class IceUITabView : IceUIBase
{
	public IceUIBtnGroup Tab;

	public IceUIBase[] Views;

	public event Action<string, IceUIBase> OnView
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public T ActiveView<T>() where T : IceUIBase
	{
		return null;
	}

	public T GetView<T>(string tab) where T : IceUIBase
	{
		return null;
	}

	private void activateView(int index, Action callback, bool playEffects = true)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}
}
