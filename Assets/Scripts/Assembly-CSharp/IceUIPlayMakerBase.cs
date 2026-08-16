using UnityEngine;

public abstract class IceUIPlayMakerBase : MonoBehaviour
{
	public delegate void H_OnCloseDelegate();

	public PlayMakerFSM animationStartFsm;

	public PlayMakerFSM animationEndFsm;

	public H_OnCloseDelegate E_OnClose;

	private bool bPlayingAnimationStart;

	protected abstract void OnStart();

	public virtual void Finish()
	{
	}

	private void Start()
	{
	}

	public void EnterScene()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void AnimationStartFinished()
	{
	}

	public void AnimationEndFinished()
	{
	}

	private void PlayAnimationStart()
	{
	}

	private void Update()
	{
	}
}
