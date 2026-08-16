using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Font")]
public class UIFont : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas;

	[SerializeField]
	[HideInInspector]
	private UIFont mReplacement;

	[SerializeField]
	[HideInInspector]
	private List<BMSymbol> mSymbols;

	[SerializeField]
	[HideInInspector]
	private Font mDynamicFont;

	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize;

	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	private UISpriteData mSprite;

	private int mPMA;

	private int mPacked;

	public BMFont bmFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool hasSymbols => false;

	public List<BMSymbol> symbols => null;

	public UIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool premultipliedAlphaShader => false;

	public bool packedFontShader => false;

	public Texture2D texture => null;

	public Rect uvRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid => false;

	[Obsolete("Use UIFont.defaultSize instead")]
	public int size
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int defaultSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UISpriteData sprite => null;

	public UIFont replacement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isDynamic => false;

	public Font dynamicFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		get
		{
			return default(FontStyle);
		}
		set
		{
		}
	}

	private Texture dynamicTexture => null;

	private void Trim()
	{
	}

	private bool References(UIFont font)
	{
		return false;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return false;
	}

	public void MarkAsChanged()
	{
	}

	public void UpdateUVRect()
	{
	}

	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	public void AddSymbol(string sequence, string spriteName)
	{
	}

	public void RemoveSymbol(string sequence)
	{
	}

	public void RenameSymbol(string before, string after)
	{
	}

	public bool UsesSprite(string s)
	{
		return false;
	}

	public void OnDestroy()
	{
	}
}
