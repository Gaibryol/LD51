using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIController : MonoBehaviour
{
	[SerializeField, Header("Objects")] private GameObject brackets;
	[SerializeField] private GameObject topBanner;
	[SerializeField] private GameObject bracketAnim;
	[SerializeField] private GameObject indicator;
	[SerializeField] private GameObject cover;
	[SerializeField] private GameObject warning;
	[SerializeField] private GameObject pause;
	[SerializeField] private GameObject hack;
	[SerializeField] private GameObject complete;
	[SerializeField] private GameObject abilityPrefab;
	[SerializeField] private List<GameObject> displayHacks;

	[SerializeField, Header("Text")] private TMP_Text score;
	[SerializeField] private TMP_Text stage;
	[SerializeField] private TMP_Text ability;
	[SerializeField] private TMP_Text pointsCompleted;
	[SerializeField] private TMP_Text stageCompleted;
	[SerializeField,Header("Sprite")] private Sprite hackCompleted;
	

	[SerializeField, Header("Indicator Animations")] private Animator indicatorAnim;

	[SerializeField, Header("Buttons")] private Toggle helpButton;
	[SerializeField] private Toggle pauseButton;
	[SerializeField] private Animator timer;
	private GameController gameController;

	private List<GameObject> abilityUses;

	public void StartGame()
	{
		InitVariables();
	}

	public void InitVariables()
	{
		brackets.SetActive(false);
		indicator.SetActive(false);
		cover.SetActive(false);

		if(abilityUses != null)
		{
			for(int i = abilityUses.Count-1; i>=0;i--){
				Destroy(abilityUses[i]);
			}
		}

		abilityUses = new List<GameObject>();
		score.text = "0";
		stage.text = "01";
		ability.text = "None";
		gameController = GetComponent<GameController>();
	}

	public void OnWordHover(float y)
	{
		brackets.SetActive(true);
		brackets.transform.localPosition = new Vector3(brackets.transform.localPosition.x, y);
		bracketAnim.transform.localPosition = brackets.transform.localPosition;

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

	public void DisplayHacks()
	{
		hack.transform.SetAsLastSibling();
		hack.SetActive(true);
	}
	public void DisplayAbility(string text, int uses){
		ability.text = text;
		if(uses > 0){
			for(int i = 0;i < uses;i++){
				GameObject abilityUse = Instantiate(abilityPrefab,gameController.Canvas.transform);
				abilityUse.transform.localPosition = new Vector3(-852 + (i*13),-430,0);
				abilityUses.Add(abilityUse);
			}
		}
	}
	public void CommpleteGame()
	{
		gameController.ChangeSubState(Constants.SubState.Complete);
		complete.transform.SetAsLastSibling();
		complete.SetActive(true);
		pointsCompleted.text = score.text;
		stageCompleted.text = stage.text;
		List<string> hacks = HacksManager.Instance.ActivatedHacks;
		for(int i = 0; i < hacks.Count; i++){
			displayHacks[i].GetComponent<Image>().sprite = hackCompleted;
			displayHacks[i].GetComponent<DisplayHack>().SetDiplayHack(hacks[i]);
		}
	}

	public void CoverWords(int numLinesShowing)
	{
		float newYAddition = (((gameController.WordPrefab.GetComponent<RectTransform>().rect.height + gameController.WordsYOffset) * (8 - gameController.MaximumNumLines)) + (gameController.WordPrefab.GetComponent<RectTransform>().rect.height + gameController.WordsYOffset) * (numLinesShowing - 1));
		cover.SetActive(true);
		cover.transform.localPosition = new Vector3(cover.transform.localPosition.x, cover.transform.localPosition.y + newYAddition);
	}

	public void PauseGame()
	{
		SoundEffectsManager.Instance.PlayOneShotSFX("ClickSound");

		if (pauseButton.isOn)
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
	public void ResetTimer()
	{
		timer.Rebind();
		timer.Update(0f);
	}

	public void ResumeGame()
	{
		SoundEffectsManager.Instance.PlayOneShotSFX("ClickSound");
		pauseButton.isOn = false;
	}

	public void RestartGame()
	{
		SoundEffectsManager.Instance.PlayOneShotSFX("ClickSound");
		pauseButton.isOn = false;
		gameController.NewGame();
	}

	public void ToMainMenu()
	{
		SoundEffectsManager.Instance.PlayOneShotSFX("ClickSound");
		pauseButton.isOn = false;
		gameController.NewGame();
		GameManager.Instance.ChangeState(Constants.GameStates.MainMenu);
	}
}
