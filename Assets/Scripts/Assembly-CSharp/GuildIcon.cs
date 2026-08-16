using System;
using UnityEngine;

public class GuildIcon : MonoBehaviour
{
	[SerializeField]
	private GameObject goSelect;

	[SerializeField]
	private UISprite spIcon;

	[SerializeField]
	private UIEventListener btnCollider;

	[NonSerialized]
	public int iconIndex;

	public Action<GuildIcon> E_OnSelect;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Select(bool bSelect)
	{
	}

	public void SetData(int iconIdx)
	{
	}
}
