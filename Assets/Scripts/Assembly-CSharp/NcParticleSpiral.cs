using UnityEngine;

public class NcParticleSpiral : NcEffectBehaviour
{
	public struct SpiralSettings
	{
		public int numArms;

		public int numPPA;

		public float partSep;

		public float turnDist;

		public float vertDist;

		public float originOffset;

		public float turnSpeed;

		public float fade;

		public float size;
	}

	public float m_fDelayTime;

	protected float m_fStartTime;

	public GameObject m_ParticlePrefab;

	public int m_nNumberOfArms;

	public int m_nParticlesPerArm;

	public float m_fParticleSeparation;

	public float m_fTurnDistance;

	public float m_fVerticalTurnDistance;

	public float m_fOriginOffset;

	public float m_fTurnSpeed;

	public float m_fFadeValue;

	public float m_fSizeValue;

	public int m_nNumberOfSpawns;

	public float m_fSpawnRate;

	protected const int Min_numArms = 1;

	protected const int Max_numArms = 10;

	protected const int Min_numPPA = 20;

	protected const int Max_numPPA = 60;

	protected const float Min_partSep = -0.3f;

	protected const float Max_partSep = 0.3f;

	protected const float Min_turnDist = -1.5f;

	protected const float Max_turnDist = 1.5f;

	protected const float Min_vertDist = 0f;

	protected const float Max_vertDist = 0.5f;

	protected const float Min_originOffset = -3f;

	protected const float Max_originOffset = 3f;

	protected const float Min_turnSpeed = -180f;

	protected const float Max_turnSpeed = 180f;

	protected const float Min_fade = -1f;

	protected const float Max_fade = 1f;

	protected const float Min_size = -2f;

	protected const float Max_size = 2f;

	private float timeOfLastSpawn;

	private int spawnCount;

	private int totParticles;

	private SpiralSettings defaultSettings;

	public override int GetAnimationState()
	{
		return 0;
	}

	public void RandomizeEditor()
	{
	}

	private void Start()
	{
	}

	private void SpawnEffect()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public SpiralSettings getSettings()
	{
		return default(SpiralSettings);
	}

	public SpiralSettings resetEffect(bool killCurrent, SpiralSettings settings)
	{
		return default(SpiralSettings);
	}

	public SpiralSettings resetEffectToDefaults(bool killCurrent)
	{
		return default(SpiralSettings);
	}

	public SpiralSettings randomizeEffect(bool killCurrent)
	{
		return default(SpiralSettings);
	}

	private void killCurrentEffects()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}
