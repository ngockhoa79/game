using System.Collections.Generic;
using UnityEngine;

public class JsonAsset : ScriptableObject
{
	public TextAsset BoneAndSlot;

	public TextAsset[] Animations;

	public void Clear()
	{
	}

	public List<TextAsset> LoadAnimationsJson(string[] animationNameList)
	{
		return null;
	}

	public List<TextAsset> LoadAllAnimationsJson()
	{
		return null;
	}

	public string LoadBoneSlotJson()
	{
		return null;
	}
}
