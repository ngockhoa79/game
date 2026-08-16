using UnityEngine;

[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPosition current;

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public bool updateScrollView;

	public OnFinished onFinished;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	public string callWhenFinished;

	private Transform mTrans;

	private float mThreshold;

	private UIScrollView mSv;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void NotifyListeners()
	{
	}

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}
}
