using UnityEngine;

public class GameStartup : MonoBehaviour
{
	public static bool playedCG;

	private bool bStarted;

	private void Awake()
	{
		if (Application.isPlaying)
		{
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
		UnityEngine.Debug.Log("[STARTUP] GameStartup Awake called");
	}

	private void Start()
	{
		bStarted = true;
		Startup();
	}

	private void Update()
	{
		if (!bStarted)
		{
			return;
		}
	}

	private void Startup()
	{
		UnityEngine.Debug.Log("[STARTUP] GameStartup Startup sequence initiated");
		if (GlobalManager.Instance != null && GlobalManager.Instance.ResourcesManager != null)
		{
			GlobalManager.Instance.ResourcesManager.LoadPolicy(1, onLoadPolicyComplete);
		}
		else
		{
			onLoadPolicyComplete();
		}
	}

	private void onLoadPolicyComplete()
	{
		UnityEngine.Debug.Log("[STARTUP] GameStartup onLoadPolicyComplete completed");
		if (GlobalManager.Instance != null && GlobalManager.Instance.ApplicationManager != null)
		{
			GlobalManager.Instance.ApplicationManager.OnCheckResourcesVersion();
		}
	}
}
