using UnityEngine;
using UnityEngine.UIElements;

namespace WebGLSupport
{
	internal class WrappedUIToolkit : IInputField
	{
		private TextField input;

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

		public WrappedUIToolkit(WebGLUIToolkitTextField input)
		{
		}

		public Rect GetScreenCoordinates()
		{
			return default(Rect);
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
	}
}
