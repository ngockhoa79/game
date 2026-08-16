using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEChapterContainer : IceUIBase
{
	private enum MyAnimationState
	{
		None = 0,
		Scrolling = 1,
		Dragging = 2,
		SlicingToLeft = 3,
		SlicingToMiddle = 4,
		SlicingToRight = 5
	}

	public UIPVEChapterView chapterMiddle;

	[HideInInspector]
	public int ProgressType;

	public float alphaDistance;

	public float deltaDistance;

	public float sliceSpeed;

	private readonly int chapterDisplayLimit;

	private int curChapterId;

	private Vector3 initPositionLeft;

	private Vector3 initPositionMiddle;

	private Vector3 initPositionRight;

	private bool bRefreshInfo;

	private bool bCheckFirstDrag;

	private MyAnimationState curState;

	public Action<UIPVEChapterInfo, int> E_OnRequestChapterView;

	public Action<GameObject, PVELevel> E_OnEnter;

	public Action<GameObject, PVELevel> E_OnSaoDang;

	public Action<GameObject, PVELevel> E_OnSelected;

	public Action E_OnAddEnergy;

	private PVEProgress CurrentProgress => null;

	public void InitView()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void Update()
	{
	}

	public void SetData(int chapterId)
	{
	}

	public void Refresh()
	{
	}

	private void SetChapter(UIPVEChapterView chapterView, int chapterId)
	{
	}

	private void InitialChapterComponent(UIPVEChapterView view)
	{
	}

	private void UninitialChapterComponennt(UIPVEChapterView view)
	{
	}

	private void OnViewEnter(GameObject go, PVELevel data)
	{
	}

	private void OnViewSaoDang(GameObject go, PVELevel data)
	{
	}

	private void OnViewSelected(GameObject go, PVELevel data)
	{
	}

	private void SetScrollable(bool enable)
	{
	}

	private void OnChapterPressed(GameObject go, PVELevel data, bool state)
	{
	}

	private void UpdateMoveToMiddle()
	{
	}

	private void AdjustPosition(float deltaX)
	{
	}

	private void ForceReset(bool bRefreshInfo = true)
	{
	}

	private void PlayChapterInfoEffect()
	{
	}
}
