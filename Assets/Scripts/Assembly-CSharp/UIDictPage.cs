using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIDictPage : MonoBehaviour
{
	public GameObject ItemAnchorPoint;

	public UILabel DebugTestLabel;

	public Action E_PageAllTextureLoadComplete;

	public static readonly int ItemRowNumber;

	public static readonly int ItemColNumber;

	private UIDictItem[] DictItems;

	private List<IllustDictUniformData> DataList;

	protected int TextureLoadCounter;

	public bool AllTexturesLoaded => false;

	public void Init()
	{
	}

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void ClearTexture()
	{
	}

	public int ReloadTexture()
	{
		return 0;
	}

	public void Dispose()
	{
	}

	public void SetData(string text)
	{
	}

	public void SetCoserData(List<HeroConfig> coserList)
	{
	}

	public void SetGearData(List<Gear> gearList)
	{
	}

	public void SetSkillData(List<Skill> skillList)
	{
	}

	public int LoadData()
	{
		return 0;
	}

	public void OnItemTextureLoaded()
	{
	}
}
