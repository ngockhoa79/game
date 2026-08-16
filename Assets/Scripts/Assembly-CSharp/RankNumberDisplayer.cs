using System.Collections.Generic;
using UnityEngine;

public class RankNumberDisplayer : MonoBehaviour
{
	private const string BadgePrefix = "Badge_";

	private const string TopNumPrefix = "Top_";

	private const string NormalNumPrefix = "Normal_";

	public Transform RankCentralAxis;

	private List<UISprite> rankSprites;

	private UISprite Badge;

	private int rank;

	private int RankSpriteDepth;

	private bool IsTopThree => false;

	public void SetRank(int _rank)
	{
	}

	public void ClearData()
	{
	}

	private void ShowRank(int rank)
	{
	}

	private string rankToSpriteName(int rank)
	{
		return null;
	}

	private UISprite createOneSprite(int rank, Transform parent, char name, int depth)
	{
		return null;
	}

	private void repositionAndScale()
	{
	}

	private float wholeWidth()
	{
		return 0f;
	}
}
