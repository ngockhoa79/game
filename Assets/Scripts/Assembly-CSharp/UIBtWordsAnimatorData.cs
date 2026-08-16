using System.Collections.Generic;
using UnityEngine;

public static class UIBtWordsAnimatorData
{
	private static Dictionary<EDmgTextType, Vector3> InitPosDic;

	private static Dictionary<EDmgTextType, Vector3> TargetPosDic;

	public static void TryAdd(EDmgTextType _type, GameObject _object)
	{
	}

	public static Vector3 GetInitPos(EDmgTextType _type, bool _left)
	{
		return default(Vector3);
	}

	public static Vector3 GetTargetPos(EDmgTextType _type, bool _left)
	{
		return default(Vector3);
	}
}
