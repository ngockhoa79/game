using UnityEngine;

public class UIStars : MonoBehaviour
{
	public enum EAlignment
	{
		Left = 0,
		Right = 1
	}

	public UITable Layout;

	public UISprite StarPrototype;

	public int Star
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public EAlignment Alignment
	{
		get
		{
			return default(EAlignment);
		}
		set
		{
		}
	}

	private void prepareWidgets()
	{
	}

	public void SetStars(int star)
	{
	}

	public virtual void RepositionStars()
	{
	}

	public EAlignment GetAlignment()
	{
		return default(EAlignment);
	}

	public void SetAlignment(EAlignment alignment)
	{
	}

	private void Start()
	{
	}
}
