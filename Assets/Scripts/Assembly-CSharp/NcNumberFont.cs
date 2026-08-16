using System;
using System.Collections.Generic;
using UnityEngine;

public class NcNumberFont : MonoBehaviour
{
	[Serializable]
	public class XNumberGlyph
	{
		public string m_Char;

		public int m_OffsetX;

		public int m_OffsetY;

		public int m_Width;

		public int m_Height;
	}

	public int m_TexWidth;

	public int m_TexHeight;

	public XNumberGlyph[] m_NumberFont;

	private Dictionary<char, Rect> m_GlyphDict;

	private void Awake()
	{
	}

	public bool GetNumberGlyph(char textChar, out Rect glyphRect)
	{
		glyphRect = default(Rect);
		return false;
	}

	public Vector2 GetTextureSize()
	{
		return default(Vector2);
	}
}
