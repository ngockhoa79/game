using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public static class UIUtil
{
	public static void Copy(Transform src, Transform dest)
	{
	}

	public static GameObject Duplicate(GameObject src)
	{
		return null;
	}

	public static bool Equals(Vector3 a, Vector3 b)
	{
		return false;
	}

	public static void AddChildren<T>(List<T> list, GameObject obj) where T : Component
	{
	}

	public static void ActivateChildren(GameObject obj, bool active)
	{
	}

	public static void SetLayer(GameObject obj, int layer)
	{
	}

	public static void SetAlpha(GameObject obj, float alpha)
	{
	}

	public static void AdjustDepth<T>(Component obj, int depthDelta) where T : UIWidget
	{
	}

	public static void AdjustDepth(GameObject target, GameObject parent, int depthDelta = 10)
	{
	}

	public static void AdjustPanelDepth(Component panel, int depthDelta)
	{
	}

	public static GameObject LoadFunnyRenderer(Hero hero, Transform placeHolder)
	{
		return null;
	}

	public static void CopyLocal2DPos(Transform target, Transform src)
	{
	}

	public static void CopyGlobal2DPos(Transform target, Transform src)
	{
	}

	public static void RandomOffset(Transform transform, Vector3 scale)
	{
	}

	public static bool IsUIWidgetVisible(UIPanel uiPanel, GameObject go)
	{
		return false;
	}

	public static void PlayIceAnimation(GameObject go, bool play)
	{
	}

	public static void PlayIceAnimatorTotalCommander(GameObject go, bool play)
	{
	}

	public static string StringLineFeed(string src, int maxWidthInSemiangle)
	{
		return null;
	}

	public static void CheckAtlas(GameObject target, string[] validateAtlasNames)
	{
	}

	public static void ColorChageForWedget(GameObject go, Color color)
	{
	}

	public static void ColorChageForSprite(GameObject go, Color color)
	{
	}

	public static void ColorChageForType<T>(GameObject go, Color color) where T : UIWidget
	{
	}

	public static void ColorDisable(GameObject go)
	{
	}

	public static void ColorEnable(GameObject go)
	{
	}

	public static void UpdateWidgetDepth(GameObject go, int compareDepth, int newMinDepth, bool includeInactive = true)
	{
	}

	public static void UpdateWidgetDepth(GameObject go, UIWidget widgetCompare, int newMinDepth, bool includeInactive = true)
	{
	}

	public static void UpdateWidgetDepthAdd(GameObject go, int addDepth, bool includeInactive = true)
	{
	}

	public static UIFont LoadBMFont(string name)
	{
		return null;
	}

	public static void EnableByTag(string tag, bool isEnable)
	{
	}

	public static void CentetChildX(Transform t)
	{
	}
}
