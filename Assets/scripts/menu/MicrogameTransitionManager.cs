using UnityEngine;

public class MicrogameTransitionManager
{

	public GameObject timeRunner;

	//Game Pots
	private string[] gamePot01 = new string[]{"microgame_01","microgame_02"};
	private string[][] gamePots;

	private int currentMicrogameInPot;
	private int currentPot;

	private GameManager gameManager;

	public MicrogameTransitionManager (GameManager _gameManager)
	{
		gamePots = new string[][]{gamePot01};
		gameManager = _gameManager;
	}

	public void StartGamePot (int index)
	{
		currentPot = index;
		currentMicrogameInPot = -1;

		NextMicrogame ();
	}

	public void NextMicrogame(){
		if (currentMicrogameInPot + 1 < gamePots [currentPot].Length) {
			currentMicrogameInPot += 1;
			Application.LoadLevel (gamePots [currentPot] [currentMicrogameInPot]);
		} else {
			currentPot = -1;
			currentMicrogameInPot = -1;
			gameManager.FinishGamePot();
		}
	}
}

