using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIArChallengers : IceUIBase
{
	private class Sync
	{
		public int Rank;

		public Transform PlaceHolder;

		public Transform Target;

		public Sync(int r, Transform placeHolder, Transform target)
		{
		}

		public void SyncPos()
		{
		}

		public bool IsBroken()
		{
			return false;
		}
	}

	private const string PrefabKey = "PlayerDisplayer";

	private const string Categroy = "uiarena";

	private readonly List<PVPPlayer> challengers;

	private readonly List<UIArTower> towers;

	[SerializeField]
	public List<PlayerDisplayer> displayers;

	private readonly List<UISprite> clouds;

	public UITable Towers;

	public Transform Displayers;

	public Transform Clouds;

	public UISprite CloudPrototype;

	private readonly List<Sync> syncs;

	private readonly List<Sync> cloudSyncs;

	private const int TOP_COUNT = 1;

	private const int HIGH_COUNT = 10;

	private const int GAP = 5;

	private Dictionary<int, Transform> towerSlots;

	private const int Minimum_Tower_Count = 8;

	public float NORMAL_TOWER_CLOUD_PROBABILITY;

	public int CLOUD_TYPE_COUNT;

	public Vector3 CLOUD_SHUFFLING_SCALING;

	public float CLOUD_SIZE_RANDOMICITY;

	public float CLOUD_MAX_WANDER_DISTANCE;

	public float CLOUD_WANDER_SPEED;

	public float CLOUD_WANDER_DIRECTION_CHANGING_PROBABILITY;

	private int scrollToIndex;

	public Player this[int index] => null;

	public PlayerDisplayer Add(PVPPlayer challenger)
	{
		return null;
	}

	public void GenerateTowers(List<int> rankList)
	{
	}

	private void noDuplication(int r)
	{
	}

	private Transform addTower(int rank)
	{
		return null;
	}

	private void addCloud(Transform slot, float probability)
	{
	}

	private PlayerDisplayer addDisplayer(PVPPlayer challenger, Transform slot)
	{
		return null;
	}

	public void SyncPos()
	{
	}

	private void sync(List<Sync> l)
	{
	}

	public void ActivateFunnyRenderers(bool activate)
	{
	}

	public void ScrollTo(int challengerIndex)
	{
	}

	private void adjustPosition(int challengerIndex)
	{
	}

	public void ConstrainOffset()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoArrange()
	{
	}

	private void PrepareScroll()
	{
	}

	private void Scaler(Vector3 s)
	{
	}

	protected override void DoDispose()
	{
	}
}
