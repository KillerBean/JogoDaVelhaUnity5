using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonsHandler : MonoBehaviour {

	public int playerID;
	public Sprite imageX;
	public Sprite imageO;
	public string player1 = "X";
	public string player2 = "O";
	public Text currentPlayerText;
	public ScoreScript scoreScript;
	public ButtonsDatabase buttonsDatabase;
	public EndMatch endMatch;
	public int numberPlays;
	public bool matchEnded = false;
	public bool canEndMatch =  false;
	public float timeMaxToEnd = 0.5f;
	public float timeToEnd = 0;

	// Use this for initialization
	void Start () {
		playerID = 1;
		currentPlayerText = currentPlayerText.GetComponent<Text>();
		buttonsDatabase = buttonsDatabase.GetComponent<ButtonsDatabase>();
		scoreScript = scoreScript.GetComponent<ScoreScript>();
		endMatch = GetComponent<EndMatch>();
	}
	
	// Update is called once per frame
	void Update () {

		if(playerID == 1){
			currentPlayerText.text = "The current player is "+player1;
		}else{
			currentPlayerText.text = "The current player is "+player2;
		}
		if(numberPlays == 9 && endMatch.player1Win != true && endMatch.player2Win != true)
		{
			canEndMatch = true;
			
			if(matchEnded){
				endMatch.isRunning = false;
				currentPlayerText.enabled = false;
				endMatch.endGameText.text = "DRAW!";
			}
		}

	}

	public void drawInButton1 (){
		if(playerID == 1 && buttonsDatabase.button1IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button1Image.sprite = imageX;
			buttonsDatabase.button1IsEmpty = false;

			if(buttonsDatabase.button2Image.sprite == imageX && buttonsDatabase.button3Image.sprite == imageX)
			{
				buttonsDatabase.button1Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button4Image.sprite == imageX && buttonsDatabase.button7Image.sprite == imageX)
			{
				buttonsDatabase.button1Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button1Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;
				
			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button1IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button1Image.sprite = imageO;
			buttonsDatabase.button1IsEmpty = false;

			if(buttonsDatabase.button2Image.sprite == imageO && buttonsDatabase.button3Image.sprite == imageO)
			{
				buttonsDatabase.button1Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button4Image.sprite == imageO && buttonsDatabase.button7Image.sprite == imageO)
			{
				buttonsDatabase.button1Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;
				
			}else if(buttonsDatabase.button5Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button1Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;
				
			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton2 (){
		if(playerID == 1 && buttonsDatabase.button2IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button2Image.sprite = imageX;
			buttonsDatabase.button2IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button3Image.sprite == imageX)
			{
				buttonsDatabase.button2Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageX && buttonsDatabase.button8Image.sprite == imageX)
			{
				buttonsDatabase.button2Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button2IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button2Image.sprite = imageO;
			buttonsDatabase.button2IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button3Image.sprite == imageO)
			{
				buttonsDatabase.button2Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageO && buttonsDatabase.button8Image.sprite == imageO)
			{
				buttonsDatabase.button2Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton3 (){
		if(playerID == 1 && buttonsDatabase.button3IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button3Image.sprite = imageX;
			buttonsDatabase.button3IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button2Image.sprite == imageX)
			{
				buttonsDatabase.button3Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button6Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button3Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageX && buttonsDatabase.button7Image.sprite == imageX)
			{
				buttonsDatabase.button3Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button3IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button3Image.sprite = imageO;
			buttonsDatabase.button3IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button2Image.sprite == imageO)
			{
				buttonsDatabase.button3Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button6Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button3Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageO && buttonsDatabase.button7Image.sprite == imageO)
			{
				buttonsDatabase.button3Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton4 (){
		if(playerID == 1 && buttonsDatabase.button4IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button4Image.sprite = imageX;
			buttonsDatabase.button4IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button7Image.sprite == imageX)
			{
				buttonsDatabase.button4Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageX && buttonsDatabase.button6Image.sprite == imageX)
			{
				buttonsDatabase.button4Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button4IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button4Image.sprite = imageO;
			buttonsDatabase.button4IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button7Image.sprite == imageO)
			{
				buttonsDatabase.button4Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageO && buttonsDatabase.button6Image.sprite == imageO)
			{
				buttonsDatabase.button4Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton5 (){
		if(playerID == 1 && buttonsDatabase.button5IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button5Image.sprite = imageX;
			buttonsDatabase.button5IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button5Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button3Image.sprite == imageX && buttonsDatabase.button7Image.sprite == imageX)
			{
				buttonsDatabase.button5Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button4Image.sprite == imageX && buttonsDatabase.button6Image.sprite == imageX)
			{
				buttonsDatabase.button5Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button2Image.sprite == imageX && buttonsDatabase.button8Image.sprite == imageX)
			{
				buttonsDatabase.button5Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button5IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button5Image.sprite = imageO;
			buttonsDatabase.button5IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button5Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button3Image.sprite == imageO && buttonsDatabase.button7Image.sprite == imageO)
			{
				buttonsDatabase.button5Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button4Image.sprite == imageO && buttonsDatabase.button6Image.sprite == imageO)
			{
				buttonsDatabase.button5Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button2Image.sprite == imageO && buttonsDatabase.button8Image.sprite == imageO)
			{
				buttonsDatabase.button5Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;
		}
	}

	public void drawInButton6 (){
		if(playerID == 1 && buttonsDatabase.button6IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button6Image.sprite = imageX;
			buttonsDatabase.button6IsEmpty = false;

			if(buttonsDatabase.button3Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button6Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button4Image.sprite == imageX && buttonsDatabase.button5Image.sprite == imageX)
			{
				buttonsDatabase.button6Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button6IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button6Image.sprite = imageO;
			buttonsDatabase.button6IsEmpty = false;

			if(buttonsDatabase.button3Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button6Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;


			}else if(buttonsDatabase.button4Image.sprite == imageO && buttonsDatabase.button5Image.sprite == imageO)
			{
				buttonsDatabase.button6Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton7 (){
		if(playerID == 1 && buttonsDatabase.button7IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button7Image.sprite = imageX;
			buttonsDatabase.button7IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button4Image.sprite == imageX)
			{
				buttonsDatabase.button7Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button8Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button7Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageX && buttonsDatabase.button3Image.sprite == imageX)
			{
				buttonsDatabase.button7Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button7IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button7Image.sprite = imageO;
			buttonsDatabase.button7IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button4Image.sprite == imageO)
			{
				buttonsDatabase.button7Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button8Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button7Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button5Image.sprite == imageO && buttonsDatabase.button3Image.sprite == imageO)
			{
				buttonsDatabase.button7Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton8 (){
		if(playerID == 1 && buttonsDatabase.button8IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button8Image.sprite = imageX;
			buttonsDatabase.button8IsEmpty = false;

			if(buttonsDatabase.button2Image.sprite == imageX && buttonsDatabase.button5Image.sprite == imageX)
			{
				buttonsDatabase.button8Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button7Image.sprite == imageX && buttonsDatabase.button9Image.sprite == imageX)
			{
				buttonsDatabase.button8Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button8IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button8Image.sprite = imageO;
			buttonsDatabase.button8IsEmpty = false;

			if(buttonsDatabase.button2Image.sprite == imageO && buttonsDatabase.button5Image.sprite == imageO)
			{
				buttonsDatabase.button8Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button7Image.sprite == imageO && buttonsDatabase.button9Image.sprite == imageO)
			{
				buttonsDatabase.button8Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void drawInButton9 (){
		if(playerID == 1 && buttonsDatabase.button9IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button9Image.sprite = imageX;
			buttonsDatabase.button9IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageX && buttonsDatabase.button5Image.sprite == imageX)
			{
				buttonsDatabase.button9Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button3Image.sprite == imageX && buttonsDatabase.button6Image.sprite == imageX)
			{
				buttonsDatabase.button9Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}else if(buttonsDatabase.button7Image.sprite == imageX && buttonsDatabase.button8Image.sprite == imageX)
			{
				buttonsDatabase.button9Image.sprite = imageX;
				endMatch.endGameText.text = "Player 1 WIN!";
				ScoreScript.scoreXInt += 1;

			}
			playerID = 2;
			numberPlays++;

		}else if(playerID == 2 && buttonsDatabase.button9IsEmpty != false && endMatch.isRunning == true && !canEndMatch){
			buttonsDatabase.button9Image.sprite = imageO;
			buttonsDatabase.button9IsEmpty = false;

			if(buttonsDatabase.button1Image.sprite == imageO && buttonsDatabase.button5Image.sprite == imageO)
			{
				buttonsDatabase.button9Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button3Image.sprite == imageO && buttonsDatabase.button6Image.sprite == imageO)
			{
				buttonsDatabase.button9Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}else if(buttonsDatabase.button7Image.sprite == imageO && buttonsDatabase.button8Image.sprite == imageO)
			{
				buttonsDatabase.button9Image.sprite = imageO;
				endMatch.endGameText.text = "Player 2 WIN!";
				ScoreScript.scoreOInt += 1;

			}
			playerID = 1;
			numberPlays++;

		}
	}

	public void delayToEnd(){
		if(canEndMatch){
			if(timeToEnd <= timeMaxToEnd){
				timeToEnd += Time.deltaTime;
			}
		}else{
			timeToEnd = 0;
		}
		if(timeToEnd >= timeMaxToEnd){
			matchEnded = true;
		}

	}

	public void resetScore(){
		ScoreScript.scoreXInt = 0;
		ScoreScript.scoreOInt = 0;
	}

	public void  backToMenu(){
		Application.LoadLevel("Menu");
	}

	public void reloadGameScene(){
		Application.LoadLevel("Scene");
	}
	
}