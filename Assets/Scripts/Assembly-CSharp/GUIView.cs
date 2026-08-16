using UnityEngine;

public class GUIView : MonoBehaviour
{
	private float progress;

	private bool muted;

	private int score;

	private string playername;

	private const string PROGRESS_KEY = "Progress";

	private const string MUTED_KEY = "IsSoundMuted";

	private const string SCORE_KEY = "Highscore";

	private const string PLAYERNAME_KEY = "PlayerName";

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public void RefreshData()
	{
	}

	public void SaveData()
	{
	}
}
