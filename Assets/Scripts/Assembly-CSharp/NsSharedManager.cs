using System.Collections.Generic;
using UnityEngine;

public class NsSharedManager : MonoBehaviour
{
	protected static NsSharedManager _inst;

	protected List<GameObject> m_SharedPrefabs;

	protected List<GameObject> m_SharedGameObjects;

	protected List<AudioClip> m_SharedAudioClip;

	protected List<List<AudioSource>> m_SharedAudioSources;

	public static NsSharedManager inst => null;

	public GameObject GetSharedParticleGameObject(GameObject originalParticlePrefab)
	{
		return null;
	}

	public void EmitSharedParticleSystem(GameObject originalParticlePrefab, int nEmitCount, Vector3 worldPos)
	{
	}

	public AudioSource GetSharedAudioSource(AudioClip audioClip, int nPriority, bool bLoop, float fVolume, float fPitch)
	{
		return null;
	}

	private AudioSource AddAudioSource(List<AudioSource> sourceList, AudioClip audioClip, int nPriority, bool bLoop, float fVolume, float fPitch)
	{
		return null;
	}

	public void PlaySharedAudioSource(bool bUniquePlay, AudioClip audioClip, int nPriority, bool bLoop, float fVolume, float fPitch)
	{
	}
}
