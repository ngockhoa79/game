using UnityEngine;

namespace Spine36.Unity
{
	public class SpineAtlasRegion : PropertyAttribute
	{
		public string atlasAssetField;

		public SpineAtlasRegion(string atlasAssetField = "")
		{
		}
	}
}
