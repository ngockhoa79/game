using UnityEngine;
using UnityEngine.UI;
using WebGLSupport.Detail;

namespace WebGLSupport
{
	internal class WrappedInputField : IInputField
	{
		private InputField input;

		private RebuildChecker checker;

		public bool ReadOnly => false;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string placeholder => null;

		public int fontSize => 0;

		public ContentType contentType => default(ContentType);

		public LineType lineType => default(LineType);

		public int characterLimit => 0;

		public int caretPosition => 0;

		public bool isFocused => false;

		public int selectionFocusPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int selectionAnchorPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool OnFocusSelectAll => false;

		public bool EnableMobileSupport => false;

		public WrappedInputField(InputField input)
		{
		}

		public void ActivateInputField()
		{
		}

		public void DeactivateInputField()
		{
		}

		public void Rebuild()
		{
		}

		public Rect GetScreenCoordinates()
		{
			return default(Rect);
		}
	}
}
