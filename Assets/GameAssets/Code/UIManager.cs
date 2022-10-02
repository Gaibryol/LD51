using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
	public static UIManager Instance { get; private set; }

	[SerializeField, Header("Objects")] private GameObject brackets;
	[SerializeField] private GameObject topBanner;
	[SerializeField] private GameObject indicator;

	[SerializeField, Header("Text")] private TMP_Text score;
	[SerializeField] private TMP_Text stage;
	[SerializeField] private GameObject cover;

	[SerializeField, Header("Indicator Animations")] private Animator indicatorAnim;

	[SerializeField, Header("Buttons")] private Toggle musicToggle;
	[SerializeField] private Toggle soundToggle;
	[SerializeField] private Button helpButton;
	[SerializeField] private Button pauseButton;

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			Instance = this;
		}

		brackets.SetActive(false);
		indicator.SetActive(false);

		score.text = "0";
		stage.text = "01";

		musicToggle.onValueChanged.AddListener((isOn) => SettingsManager.Instance.ToggleMusic(isOn));
		soundToggle.onValueChanged.AddListener((isOn) => SettingsManager.Instance.ToggleSound(isOn));
	}

	public void OnWordHover(float y)
	{
		brackets.SetActive(true);
		brackets.transform.localPosition = new Vector3(brackets.transform.localPosition.x, y);

		indicator.SetActive(true);
		indicator.transform.localPosition = new Vector3(indicator.transform.localPosition.x, y);

		indicatorAnim.Play("Solving");
	}

	public void OnWordExit()
	{
		brackets.SetActive(false);
		indicator.SetActive(false);
	}

	public void OnSpawnWord()
	{
		cover.transform.SetAsLastSibling();
		topBanner.transform.SetAsLastSibling();
	}

	public void OnStageComplete(int newStage)
	{
		stage.text = "0" + newStage.ToString();
	}

	public void OnWordSolved(int amount)
	{
		int newScore = int.Parse(score.text) + amount;
		score.text = newScore.ToString();
	}

	public void CoverWords(int amount)
	{
		RectTransform rt = cover.GetComponent<RectTransform>();
		rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y +(amount*100));
	}
}
