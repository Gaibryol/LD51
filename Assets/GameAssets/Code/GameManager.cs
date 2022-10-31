using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }

	[SerializeField] public Canvas Canvas;
	[SerializeField] public Constants.GameStates GameState;
    [SerializeField] public Constants.PlayMode PlayMode;
	[SerializeField] public Texture2D crosshair;

    [SerializeField] public GamePrefs GamePrefs;

    private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        Cursor.SetCursor(crosshair, Vector2.zero, CursorMode.Auto);

		GameState = Constants.GameStates.MainMenu;
        GamePrefs = new GamePrefs();
    }

    public void ChangePlayMode(Constants.PlayMode playMode)
    {
        PlayMode = playMode;
    }

    public void ChangeState(Constants.GameStates newState)
	{
		GameState = newState;

        if (GameState == Constants.GameStates.Game)
		{
			SoundEffectsManager.Instance.PlayGameMusic();
            if (PlayMode == Constants.PlayMode.Single)
            {
                SceneManager.LoadScene("GameScene");
            } else
            {
                PhotonNetwork.LoadLevel("GameScene");
            }
        }
		else if (GameState == Constants.GameStates.MainMenu)
		{
            SoundEffectsManager.Instance.PlayMainMenuMusic();
            SceneManager.LoadScene("TitleScene");
		} else if (GameState == Constants.GameStates.Credits)
        {
            SoundEffectsManager.Instance.PlayMainMenuMusic();
            SceneManager.LoadScene("CreditScene");
        } else if (GameState == Constants.GameStates.Lobby)
        {
            PhotonNetwork.LoadLevel("LobbyScene");
        } else if (GameState == Constants.GameStates.Room)
        {
            PhotonNetwork.LoadLevel("RoomScene");
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        Canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
    }
}
