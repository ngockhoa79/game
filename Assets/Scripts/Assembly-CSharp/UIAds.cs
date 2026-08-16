using UnityEngine;
using UnityEngine.UI;

public class UIAds : MonoBehaviour
{
	[SerializeField]
	private Button closeBtn;

	[SerializeField]
	private Button confirmBtn;

	[SerializeField]
	private Text descTxt;

	private bool isLoading;

	private const string DescFromat = "观看次数：{0}/10";

	private void Start()
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickConfirm()
	{
	}

	public static UIAds Show(Transform parent = null)
	{
		return null;
	}
}
