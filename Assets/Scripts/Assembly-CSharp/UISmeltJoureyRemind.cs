using System;
using UnityEngine;

public class UISmeltJoureyRemind : IceUIBase
{
	public UILabel lblText1;

	public UILabel lblText2;

	public UILabel lblText3;

	public UILabel lblText4;

	public GameObject s1;

	public GameObject s2;

	public GameObject s3;

	public UIEventListener EnsureButton;

	public Action OnEnsure;

	public void SetData(int stageType)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}
}
