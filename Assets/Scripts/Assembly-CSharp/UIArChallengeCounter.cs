using UnityEngine;

public class UIArChallengeCounter : MonoBehaviour
{
	public UILabel ChallengeCounter;

	public UILabel ChallengeCDDisplayer;

	public UIEventListener RefreshBtn;

	public GameObject RefreshGO;

	public UISprite RemainLabelBG;

	private int usedCount;

	private int seconds;

	private Timer t;

	private int ccount;

	public int CCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	private void prepareWidgets()
	{
	}

	public void SetDetails(long cool, int used)
	{
	}

	private string formatCD(long ticks)
	{
		return null;
	}

	public void SetUsed(int used)
	{
	}

	private void setCCount()
	{
	}

	private void Start()
	{
	}

	private void popConfirmDialog(GameObject btn)
	{
	}

	private void sendResetCDReq(int cost)
	{
	}

	private void popMsg(string msg)
	{
	}

	private void OnDestroy()
	{
	}
}
