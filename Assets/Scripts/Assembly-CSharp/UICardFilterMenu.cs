using System;
using UnityEngine;

public class UICardFilterMenu : IceUIBase
{
	[Serializable]
	public class FilterButtonGroup
	{
		public UIEventListener Select;

		public GameObject normal;

		public GameObject selected;
	}

	[SerializeField]
	private FilterButtonGroup[] JobGroup;

	[SerializeField]
	private FilterButtonGroup[] SortGroup;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private UIEventListener CancelButton;

	[SerializeField]
	private GameObject JobBar;

	[SerializeField]
	private GameObject SortBar;

	public Action OnEnsure;

	public Action OnCancel;

	private float strength;

	private float correctedValue;

	private bool IsJobSelected;

	private bool IsSortSelected;

	private Vector3 jobTarget;

	private Vector3 sortTarget;

	private int jobIndex;

	private int sortIndex;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void ResetFilter()
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject obj)
	{
	}

	private void SelectJobOption(GameObject obj)
	{
	}

	private void SelectSortOption(GameObject obj)
	{
	}

	private void OnSelectOption(FilterButtonGroup group, bool flag)
	{
	}

	private void Update()
	{
	}
}
