using System;

public class IceUIBtnGroup : IceUIBase
{
	[Serializable]
	public class NamedBtn
	{
		public string Name;

		public IceUIToggleButton Button;
	}

	public NamedBtn[] Buttons;

	private int selection;

	public int DefaultIndex;

	public Action<string, string> OnButtonSelected;

	public Action<int, int> OnButtonSelected_Index;

	public string SelectedButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int SelectedButtonIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int GetButton(string name)
	{
		return 0;
	}

	private void selectButton(int index, bool triggerEvent)
	{
	}

	public void SelectButton(string button, bool triggerEvent)
	{
	}

	public void SelectButton(int index, bool triggerEvent)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
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
