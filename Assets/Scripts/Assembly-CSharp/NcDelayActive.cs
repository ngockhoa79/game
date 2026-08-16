public class NcDelayActive : NcEffectBehaviour
{
	public string NotAvailable;

	public float m_fDelayTime;

	public bool m_bActiveRecursively;

	protected float m_fAliveTime;

	public float m_fParentDelayTime;

	protected bool m_bAddedInvoke;

	protected float m_fStartedTime;

	public float GetParentDelayTime(bool bCheckStarted)
	{
		return 0f;
	}
}
