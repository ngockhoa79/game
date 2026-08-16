using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgSkillUpgrader : IceUIBase
{
	[Serializable]
	public class StoneStruct
	{
		public UICmItemIcon Stone;

		public UISprite LackMask;

		public UILabel Collections;

		public ERarity rarity;
	}

	[Serializable]
	public class MaterialStruct
	{
		public UniIcon Material;

		public UILabel Collections;

		public UISprite SpEquiped;

		public UICmStarDisplayer Star;

		public UIEventListener Button;
	}

	private List<SkillHolding> skillUsages;

	private int[] stoneUsages;

	public UILabel NameText;

	public UniIcon CurrSkillIcon;

	public GameObject EmptySlot;

	public UICmStarDisplayer CurrentStar;

	public UICmStarDisplayer UpgradedStar;

	public UICmStarDisplayer MaxStar;

	public UILabel CurrentEffectDesc;

	public UILabel UpgradedEffectDesc;

	public UILabel MaxEffectDesc;

	public UILabel CostText;

	public UILabel GoldText;

	public UILabel StoneNumber;

	public UISprite ImgStone;

	public UISprite ImgTxtAddStone;

	public UISprite CostIcon;

	public UISprite SpChange;

	public UIEventListener UpgradeButton;

	public UIEventListener HomePageButton;

	public UIEventListener ReturnButton;

	public UIEventListener SkillSelectButton;

	public UIEventListener AddStoneButton;

	public UIEventListener SkillExchangeButton;

	public UIEventListener FragmentRobButton;

	public List<UIEventListener> EmptyMatSlots;

	public List<MaterialStruct> MatSlots;

	public GameObject EffectObj;

	public GameObject StarObj;

	public GameObject MaxObj;

	public UISprite MaxIcon;

	public StoneStruct Stones;

	public Action<SkillHolding, List<SkillHolding>, int[]> OnUpgrade;

	public Action<string> OnBadUpgrade;

	public Action OnHomePage;

	public Action OnReturn;

	public Action OnSelectSkill;

	public Action E_OnFragmentRob;

	public Action<ItemHolding, int> OnAddMaterial;

	private string precondition;

	private SkillHolding target;

	private int EmptySlotsCount;

	private GameObject popupObj;

	private UILgSkillUpgradeSuccess popupui;

	private int StoneNumberValue;

	public IceAnimatorTotalCommander enabledAnim;

	public IceAnimatorTotalCommander skillPickAnim;

	public IceAnimatorTotalCommander[] matAnim;

	private ERarity StoneRarity => default(ERarity);

	private int SkillUpgradeStones
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private ItemHolding StoneHolding => null;

	public SkillHolding TargetSkill
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	public void ClearMaterials()
	{
	}

	private void set(SkillHolding target)
	{
	}

	private void displayStones()
	{
	}

	private int sacrificesCount()
	{
		return 0;
	}

	private void updateSacrificesText()
	{
	}

	public void SetMaterialSlot(int _slot, SkillHolding _mat)
	{
	}

	public void OnSetMatClick()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void ResetMaterialArray()
	{
	}

	private int GetSkillLevelReplacedStoneSimpleCount(int skillStar)
	{
		return 0;
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomePageClicked(GameObject obj)
	{
	}

	private void OnSelectSkillClicked(GameObject obj)
	{
	}

	private void OnAddMatSkillClicked(GameObject obj)
	{
	}

	private void OnUndoMatSkillSelected(GameObject obj)
	{
	}

	private void OnAddStones2EmptySlot(GameObject obj)
	{
	}

	private void OnAutoAddClicked(GameObject obj)
	{
	}

	private void OnUpgradeClicked(GameObject obj)
	{
	}

	public void AutoAddMaterials()
	{
	}

	public void OnPopupSuccess(SkillHolding holding, Action callback)
	{
	}

	public void PlayAnimations()
	{
	}

	public void StopAnimations()
	{
	}

	private bool isMaterialsEnough()
	{
		return false;
	}

	private void OnFragmentRobButtonClicked(GameObject obj)
	{
	}
}
