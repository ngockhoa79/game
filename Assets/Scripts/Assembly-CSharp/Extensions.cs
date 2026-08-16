using UnityEngine;

public static class Extensions
{
	public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagnitudePrecision)
	{
		return false;
	}

	public static bool AlmostEquals(this Vector2 target, Vector2 second, float sqrMagnitudePrecision)
	{
		return false;
	}

	public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
	{
		return false;
	}

	public static bool AlmostEquals(this float target, float second, float floatDiff)
	{
		return false;
	}
}
