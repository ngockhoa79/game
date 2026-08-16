using UnityEngine;

public class Init : MonoBehaviour
{
	private UIEventListener quit;

	private UISprite mask;

	private MeshCollider obstacle;

	private UIEventListener stimulate;

	private Transform npc;

	private Transform sketch;

	private Transform draft;

	private Transform finger;

	private UISprite[] allSprites;

	public UIEventListener Quit => null;

	public UISprite Mask => null;

	public MeshCollider Obstacle => null;

	public UIEventListener Stimulate => null;

	public Transform NPC => null;

	public Transform Sketch => null;

	public Transform Draft => null;

	public Transform Finger => null;

	private void Awake()
	{
	}

	private void findAllSprites()
	{
	}

	public void ActivateAllChildernsSprites(bool active)
	{
	}

	private void findChildren()
	{
	}

	private void disableAsDefault()
	{
	}

	private void OnDestroy()
	{
	}
}
