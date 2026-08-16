using System;
using UnityEngine;

public class CharacterSkeletonData : MonoBehaviour
{
	[Serializable]
	public class CharacterSkeletonDataContent
	{
		public CharactersType characterType;

		public JsonAsset json;
	}

	public CharacterSkeletonDataContent[] JsonDataList;

	public JsonAsset GetJsonAsset(CharactersType characterType)
	{
		return null;
	}

	public TextAsset[] GetAnimationTextAsset(CharactersType characterType, string[] animations = null)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
