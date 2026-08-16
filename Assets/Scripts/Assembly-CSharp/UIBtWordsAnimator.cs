using UnityEngine;

public class UIBtWordsAnimator : MonoBehaviour
{
	public UILabel Text;

	public GameObject AnimList;

	public GameObject heal;

	public GameObject crit;

	public GameObject normal;

	public GameObject text_increase;

	public GameObject text_decrease;

	public GameObject text_block;

	public GameObject text_combo;

	public GameObject text_dodge;

	private bool playing;

	private float timer;

	private float totalTime;

	public void Play(string _text, EDmgTextType _type, bool _left)
	{
	}

	private void Update()
	{
	}
}
