using UnityEngine;
using UnityEngine.UIElements;

namespace WebGLSupport
{
	public class WebGLInputManipulator : Manipulator
	{
		private GameObject go;

		private bool showHtmlElement;

		public WebGLInputManipulator(bool showHtmlElement = false)
		{
		}

		protected override void RegisterCallbacksOnTarget()
		{
		}

		protected override void UnregisterCallbacksFromTarget()
		{
		}

		private void OnFocusInEvent(FocusInEvent evt)
		{
		}

		private void OnFocusOutEvent(FocusOutEvent evt)
		{
		}
	}
}
