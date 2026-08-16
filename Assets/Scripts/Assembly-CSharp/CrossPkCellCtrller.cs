using UnityEngine;

public class CrossPkCellCtrller : MonoBehaviour
{
	private enum CellType
	{
		Empty = 0,
		MyCell = 1,
		FriendCell = 2
	}

	public UISprite romaNum;

	public UISprite roleType;

	public UITexture headIcon;

	public UISprite vip;

	public UIEventListener zoomBtn;

	public UIEventListener loadBtn;

	public UIEventListener unloadBtn;

	public UILabel playerName;

	public Transform powerTran;

	public UILabel power;

	public UILabel level;

	private GuildPkCellInfo info;

	private int line;

	private CellType cellType;

	private int CellRealIndex => 0;

	private int CellIndex => 0;

	public void SetData(GuildPkCellInfo _info, int _line)
	{
	}

	private void SetUI()
	{
	}

	private void tip(string t)
	{
	}

	private void OnLoadClicked(GameObject _obj)
	{
	}

	private void OnUnloadClicked(GameObject _obj)
	{
	}

	private void OnZoomClicked(GameObject _obj)
	{
	}
}
