namespace WebGLSupport.Detail
{
	public class RebuildChecker
	{
		private IInputField input;

		private string beforeString;

		private int beforeCaretPosition;

		private int beforeSelectionFocusPosition;

		private int beforeSelectionAnchorPosition;

		public RebuildChecker(IInputField input)
		{
		}

		public bool NeedRebuild(bool debug = false)
		{
			return false;
		}
	}
}
