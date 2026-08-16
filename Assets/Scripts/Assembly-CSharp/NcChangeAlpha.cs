using UnityEngine;

public class NcChangeAlpha : NcEffectBehaviour
{
	public enum TARGET_TYPE
	{
		MeshColor = 0,
		MaterialColor = 1
	}

	public enum CHANGE_MODE
	{
		FromTo = 0
	}

	public TARGET_TYPE m_TargetType;

	public float m_fDelayTime;

	public float m_fChangeTime;

	public bool m_bRecursively;

	public CHANGE_MODE m_ChangeMode;

	public float m_fFromAlphaValue;

	public float m_fToMeshValue;

	protected float m_fStartTime;

	protected float m_fStartChangeTime;

	public static NcChangeAlpha SetChangeTime(GameObject baseGameObject, float fLifeTime, float fChangeTime, float fFromMeshAlphaValue, float fToMeshAlphaValue)
	{
		return null;
	}

	public void SetChangeTime(float fDelayTime, float fChangeTime, float fFromAlphaValue, float fToAlphaValue)
	{
	}

	public void Restart()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartChange()
	{
	}

	private void ChangeToAlpha(float fElapsedRate)
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}
