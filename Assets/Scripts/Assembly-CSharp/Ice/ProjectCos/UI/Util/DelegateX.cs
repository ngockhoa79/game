using System;

namespace Ice.ProjectCos.UI.Util
{
	public static class DelegateX
	{
		public static void InvokeSafely(this Action action)
		{
			if (action != null)
			{
				try
				{
					action();
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogWarning($"[DelegateX] Exception in InvokeSafely: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}

		public static void InvokeSafely<T>(this Action<T> action, T t)
		{
			if (action != null)
			{
				try
				{
					action(t);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogWarning($"[DelegateX] Exception in InvokeSafely<T>: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}

		public static void InvokeSafely<T1, T2>(this Action<T1, T2> action, T1 t1, T2 t2)
		{
			if (action != null)
			{
				try
				{
					action(t1, t2);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogWarning($"[DelegateX] Exception in InvokeSafely<T1,T2>: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}

		public static void InvokeSafely<T1, T2, T3>(this Action<T1, T2, T3> action, T1 t1, T2 t2, T3 t3)
		{
			if (action != null)
			{
				try
				{
					action(t1, t2, t3);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogWarning($"[DelegateX] Exception in InvokeSafely<T1,T2,T3>: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}

		public static void InvokeSafely<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 t1, T2 t2, T3 t3, T4 t4)
		{
			if (action != null)
			{
				try
				{
					action(t1, t2, t3, t4);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogWarning($"[DelegateX] Exception in InvokeSafely<T1,T2,T3,T4>: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}
	}
}
