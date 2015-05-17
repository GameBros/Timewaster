using UnityEngine;
using System.Collections;

public class GameManager{

	private MicrogameTransitionManager microgameManager;

	//Game States
	public enum GameState {Menu, Microgame}
	private GameState gameState;

	private static GameManager _instance;

	private GameManager(){}

	public static GameManager Instance(){
		if (_instance == null) {
			_instance = new GameManager();
			_instance.Init();
		}
		return _instance;
	}

	private void Init(){
		microgameManager = new MicrogameTransitionManager (_instance);
		gameState = GameState.Menu;
	}

	public void Quit(){
		Application.Quit ();
	}

	public void BackToTitle ()
	{
		if (gameState == GameState.Menu) {
			Application.LoadLevel("scene_title");
		}
	}

	public void StartGame ()
	{
		Application.LoadLevel ("scene_microgames_menu");
	}

	public void StartMicroGames (int index)
	{
		gameState = GameState.Microgame;
		microgameManager.StartGamePot (index);
	}

	//The time of a microgame has reached it's end
	public void TimeUp ()
	{
		if (gameState == GameState.Microgame) {
			microgameManager.NextMicrogame();
		}
	}

	public void FinishGamePot ()
	{
		gameState = GameState.Menu;
		Application.LoadLevel ("scene_microgames_menu");
	}

}
