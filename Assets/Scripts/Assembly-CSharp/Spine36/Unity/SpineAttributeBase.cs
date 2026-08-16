using System;
using UnityEngine;

namespace Spine36.Unity
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class SpineAttributeBase : PropertyAttribute
	{
		public string dataField;

		public string startsWith;

		public bool includeNone;

		public bool fallbackToTextField;
	}
}
