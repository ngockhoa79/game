using UnityEngine;

namespace Ice.ProjectCos.UI.Util
{
	public class UILoader
	{
		public static GameObject Load(string resName, string resCategory, Transform parent)
		{
			if (string.IsNullOrEmpty(resName))
			{
				return null;
			}

			GameObject prefab = null;
			string cleanCat = (!string.IsNullOrEmpty(resCategory)) ? resCategory.ToLowerInvariant().Replace("ui", "") : "";
			string[] candidates = new string[]
			{
				$"ui/{resCategory}/{resName}",
				$"ui/{resCategory}/UI{resName}",
				$"ui/{resCategory}/{resName}UI",
				$"ui/{cleanCat}/{resName}",
				$"ui/{cleanCat}/UI{resName}",
				$"ui/{cleanCat}/{resName}UI",
				$"ui/mainscene/{resName}",
				$"ui/{resName}",
				$"ui/UI{resName}",
				$"ui/{resName}UI",
				resName
			};

			foreach (string candidate in candidates)
			{
				if (string.IsNullOrEmpty(candidate)) continue;
				prefab = Resources.Load<GameObject>(candidate);
				if (prefab != null)
				{
					break;
				}
			}

			if (prefab != null)
			{
				GameObject instance = Object.Instantiate(prefab, parent);
				if (instance != null)
				{
					instance.name = resName;
					return instance;
				}
			}

			Debug.LogWarning($"[UILoader] Failed to load prefab '{resName}' in category '{resCategory}'");
			return null;
		}

		public static T Load<T>(string resName, string resCategory, Transform parent) where T : Component
		{
			GameObject go = Load(resName, resCategory, parent);
			if (go != null)
			{
				T comp = go.GetComponent<T>();
				if (comp == null)
				{
					comp = go.GetComponentInChildren<T>(true);
				}
				return comp;
			}
			return null;
		}

		public static T Load<T>(string resName, string resCategory, Transform parent, int depth) where T : Component
		{
			T component = Load<T>(resName, resCategory, parent);
			if (component != null)
			{
				UIPanel panel = component.GetComponent<UIPanel>();
				if (panel != null)
				{
					panel.depth = depth;
				}
			}
			return component;
		}

		public static void Destroy(ref GameObject component)
		{
			if (component != null)
			{
				Object.Destroy(component);
				component = null;
			}
		}

		public static void DestroyImmediate(ref GameObject component)
		{
			if (component != null)
			{
				Object.DestroyImmediate(component);
				component = null;
			}
		}

		public static void Destroy<T>(ref T component) where T : Component
		{
			if (component != null)
			{
				Object.Destroy(component.gameObject);
				component = null;
			}
		}

		public static void DestroyImmediate<T>(ref T component) where T : Component
		{
			if (component != null)
			{
				Object.DestroyImmediate(component.gameObject);
				component = null;
			}
		}

		public static void Destroy(GameObject component)
		{
			if (component != null)
			{
				Object.Destroy(component);
			}
		}

		public static void DestroyImmediate(GameObject component)
		{
			if (component != null)
			{
				Object.DestroyImmediate(component);
			}
		}
	}
}
