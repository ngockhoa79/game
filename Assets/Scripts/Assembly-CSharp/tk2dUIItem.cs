using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIItem")]
public class tk2dUIItem : MonoBehaviour
{
	public GameObject sendMessageTarget;

	public string SendMessageOnDownMethodName;

	public string SendMessageOnUpMethodName;

	public string SendMessageOnClickMethodName;

	public string SendMessageOnReleaseMethodName;

	[SerializeField]
	private bool isChildOfAnotherUIItem;

	public bool registerPressFromChildren;

	public bool isHoverEnabled;

	public Transform[] editorExtraBounds;

	public Transform[] editorIgnoreBounds;

	private bool isPressed;

	private bool isHoverOver;

	private tk2dUITouch touch;

	private tk2dUIItem parentUIItem;

	public bool IsPressed => false;

	public tk2dUITouch Touch => default(tk2dUITouch);

	public tk2dUIItem ParentUIItem => null;

	public event Action OnDown
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

	public event Action OnUp
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

	public event Action OnClick
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

	public event Action OnRelease
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

	public event Action OnHoverOver
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

	public event Action OnHoverOut
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

	public event Action<tk2dUIItem> OnDownUIItem
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

	public event Action<tk2dUIItem> OnUpUIItem
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

	public event Action<tk2dUIItem> OnClickUIItem
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

	public event Action<tk2dUIItem> OnReleaseUIItem
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

	public event Action<tk2dUIItem> OnHoverOverUIItem
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

	public event Action<tk2dUIItem> OnHoverOutUIItem
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateParent()
	{
	}

	public void ManuallySetParent(tk2dUIItem newParentUIItem)
	{
	}

	public void RemoveParent()
	{
	}

	public bool Press(tk2dUITouch touch)
	{
		return false;
	}

	public bool Press(tk2dUITouch touch, tk2dUIItem sentFromChild)
	{
		return false;
	}

	public void UpdateTouch(tk2dUITouch touch)
	{
	}

	private void DoSendMessage(string methodName)
	{
	}

	public void Release()
	{
	}

	public void CurrentOverUIItem(tk2dUIItem overUIItem)
	{
	}

	public bool CheckIsUIItemChildOfMe(tk2dUIItem uiItem)
	{
		return false;
	}

	public void Exit()
	{
	}

	public bool HoverOver(tk2dUIItem prevHover)
	{
		return false;
	}

	public void HoverOut(tk2dUIItem currHoverButton)
	{
	}

	private tk2dUIItem GetParentUIItem()
	{
		return null;
	}

	public void SimulateClick()
	{
	}

	public void InternalSetIsChildOfAnotherUIItem(bool state)
	{
	}

	public bool InternalGetIsChildOfAnotherUIItem()
	{
		return false;
	}
}
