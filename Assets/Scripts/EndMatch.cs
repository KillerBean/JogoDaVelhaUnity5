﻿using UnityEngine;
using UnityEngine.UI;

public class EndMatch : MonoBehaviour {
	public ButtonsDatabase buttonsDatabase;
	public ButtonsHandler buttonsHandler;
	public bool isRunning;
	public bool player1Win;
	public bool player2Win;
	public Text endGameText;
	public Button buttonAgain;
	public Button buttonBackToMenu;
	public Button buttonResetScore;
	public Text textResetScore;
	public Text textPlayAgain;
	public Text textBackToMenu;
	public Image imageAtEnd;
	public ScoreScript scoreScript;

	// Use this for initialization
	void Start () {
		buttonsDatabase = buttonsDatabase.GetComponent<ButtonsDatabase>();
		buttonsHandler = GetComponent<ButtonsHandler>();
		endGameText = endGameText.GetComponent<Text>();
		buttonAgain = buttonAgain.GetComponent<Button>();
		imageAtEnd = imageAtEnd.GetComponent<Image>();
		buttonBackToMenu = buttonBackToMenu.GetComponent<Button>();
		scoreScript = scoreScript.GetComponent<ScoreScript>();
		buttonResetScore = buttonResetScore.GetComponent<Button>();
		textResetScore = buttonResetScore.GetComponentInChildren<Text>();
		textBackToMenu = buttonBackToMenu.GetComponentInChildren<Text>();
		textPlayAgain = buttonAgain.GetComponentInChildren<Text>();
		isRunning = true;
	}
	
	// Update is called once per frame
	void Update () {
		buttonsHandler.delayToEnd();


		 if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageX && buttonsDatabase.button5Image.sprite == buttonsHandler.imageX && buttonsDatabase.button9Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageX && buttonsDatabase.button4Image.sprite == buttonsHandler.imageX && buttonsDatabase.button7Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageX && buttonsDatabase.button2Image.sprite == buttonsHandler.imageX && buttonsDatabase.button3Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button4Image.sprite == buttonsHandler.imageX && buttonsDatabase.button5Image.sprite == buttonsHandler.imageX && buttonsDatabase.button6Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button7Image.sprite == buttonsHandler.imageX && buttonsDatabase.button8Image.sprite == buttonsHandler.imageX && buttonsDatabase.button9Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button7Image.sprite == buttonsHandler.imageX && buttonsDatabase.button5Image.sprite == buttonsHandler.imageX && buttonsDatabase.button3Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button2Image.sprite == buttonsHandler.imageX && buttonsDatabase.button5Image.sprite == buttonsHandler.imageX && buttonsDatabase.button8Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button3Image.sprite == buttonsHandler.imageX && buttonsDatabase.button6Image.sprite == buttonsHandler.imageX && buttonsDatabase.button9Image.sprite == buttonsHandler.imageX)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player1Win = true;
			}

		}else if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageO && buttonsDatabase.button5Image.sprite == buttonsHandler.imageO && buttonsDatabase.button9Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageO && buttonsDatabase.button4Image.sprite == buttonsHandler.imageO && buttonsDatabase.button7Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button1Image.sprite == buttonsHandler.imageO && buttonsDatabase.button2Image.sprite == buttonsHandler.imageO && buttonsDatabase.button3Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button4Image.sprite == buttonsHandler.imageO && buttonsDatabase.button5Image.sprite == buttonsHandler.imageO && buttonsDatabase.button6Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button7Image.sprite == buttonsHandler.imageO && buttonsDatabase.button8Image.sprite == buttonsHandler.imageO && buttonsDatabase.button9Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button7Image.sprite == buttonsHandler.imageO && buttonsDatabase.button5Image.sprite == buttonsHandler.imageO && buttonsDatabase.button3Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button2Image.sprite == buttonsHandler.imageO && buttonsDatabase.button5Image.sprite == buttonsHandler.imageO && buttonsDatabase.button8Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}else if(buttonsDatabase.button3Image.sprite == buttonsHandler.imageO && buttonsDatabase.button6Image.sprite == buttonsHandler.imageO && buttonsDatabase.button9Image.sprite == buttonsHandler.imageO)
		{
			buttonsHandler.canEndMatch = true;
			
			if(buttonsHandler.matchEnded){
				isRunning = false;
				player2Win = true;
			}

		}

		if(!isRunning){
            endGameText.gameObject.SetActive(true);
            buttonAgain.gameObject.SetActive(true);
            buttonBackToMenu.gameObject.SetActive(true);
            imageAtEnd.gameObject.SetActive(true);
            buttonResetScore.gameObject.SetActive(true);
            textResetScore.gameObject.SetActive(true);
            textPlayAgain.gameObject.SetActive(true);
            textBackToMenu.gameObject.SetActive(true);
            buttonsHandler.currentPlayerText.gameObject.SetActive(false);
        }
        else{
            endGameText.gameObject.SetActive(false);
            buttonAgain.gameObject.SetActive(false);
            buttonBackToMenu.gameObject.SetActive(false);
            imageAtEnd.gameObject.SetActive(false);
            buttonResetScore.gameObject.SetActive(false);
            textResetScore.gameObject.SetActive(false);
            textPlayAgain.gameObject.SetActive(false);
            textBackToMenu.gameObject.SetActive(false);
            buttonsHandler.currentPlayerText.gameObject.SetActive(true);
            //}
        }
	}

}
