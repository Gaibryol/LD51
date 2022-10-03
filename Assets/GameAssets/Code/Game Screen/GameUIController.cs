using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIController : MonoBehaviour
{
	[SerializeField, Header("Objects")] private GameObject brackets;
	[SerializeField] private GameObject topBanner;
	[SerializeField] private GameObject indicator;

	[SerializeField, Header("Text")] private TMP_Text score;
	[SerializeField] private TMP_Text stage;
	[SerializeField] private GameObject cover;
	[SerializeField] private GameObject warning;
	[SerializeField] private GameObject pause;
	[SerializeField] private GameObject hack;

	[SerializeField, Header("Indicator Animations")] private Animator indicatorAnim;

	[SerializeField, Header("Buttons")] private Toggle helpButton;
	[SerializeField] private Toggle pauseButton;
	[SerializeField] private Animator timer;
	private GameController gameController;

	public void StartGame()
	{
		InitVariables();
	}

	private void InitVariables()
	{
		brackets.SetActive(false);
		indicator.SetActive(false);

		score.text = "0";
		stage.text = "01";
		gameController = GetComponent<GameController>();
	}

	public void OnWordHover(float y)
	{
		brackets.SetActive(true);
		brackets.transform.localPosition = new Vector3(brackets.transform.localPosition.x, y);

		indicator.SetActive(true);
		indicator.transform.localPosition = new Vector3(indicator.transform.localPosition.x, y);

		indicatorAnim.Play("Solving");
	}

	public void DisplayWarning(bool show)
	{
		warning.SetActive(show);
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
		int newScore = amount;
		score.text = newScore.ToString();
	}

	public void DisplayHacks(){
		hack.SetActive(true);
	}

	public void CoverWords(int amount)
	{
		RectTransform rt = cover.GetComponent<RectTransform>();
		rt.sizeDelta = new Vector2(rt.sizeDelta.x, amount*100);
	}
	public void PauseGame(){
		if(pauseButton.isOn)
		{
			gameController.ChangeSubState(Constants.SubState.Pause);
			pause.transform.SetAsLastSibling();
			pause.SetActive(true);
			timer.enabled = false;
		}
		else{
			gameController.ChangeSubState(Constants.SubState.Playing);
			pause.SetActive(false);
			timer.enabled = true;
		}
	}
	public void ResetTimer(){
		timer.Rebind();
		timer.Update(0f);
	}
	public void ResumeGame(){
		pauseButton.isOn = false;
	}
	public void RestartGame(){
		pauseButton.isOn = false;
		gameController.NewGame();
	}
	public void ToMainMenu(){
		pauseButton.isOn = false;
		gameController.NewGame();
		GameManager.Instance.ChangeState(Constants.GameStates.MainMenu);
	}
}
