using UnityEngine;

public class UIConvoyShipMapDot : IceUIBase
{
	[SerializeField]
	private UISprite DotSprite;

	public float dataDistance { get; set; }

	public float realDistance { get; set; }

	public float dataSpeed { get; set; }

	public float realSpeed { get; set; }

	public int playerID { get; set; }

	public int shipID { get; set; }

	public bool shipCreatedByMe { get; set; }

	public void SetData(int playerID, int shipID, float realSpeed, float dataSpeed, float realDistance, float dataDistance, bool createdByMe)
	{
	}
}
