using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class Navigator
	{
		private List<IceUIIntent> mItents;

		private List<Action> mActions;

		public string Icon { get; set; }

		public string UIName { get; set; }

		public DropLevelClient DropLevel { get; set; }

		public IceUIIntent LastInent => null;

		public void AddIntent(IceUIIntent it)
		{
		}

		public void AddIntentParam(IceUIIntent it, Action onComplete, bool hidePrivious, bool playerEnterEffect, bool playerExitEffect)
		{
		}

		public void AddAction(Action action)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void Perform()
		{
		}

		public bool IsAbleToPerform(bool showMessage = false)
		{
			return false;
		}
	}
}
