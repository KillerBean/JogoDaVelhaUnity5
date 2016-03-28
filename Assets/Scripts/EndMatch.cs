using UnityEngine;
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

        UpdateBoard();

        InGame();

	}

    public void UpdateBoard()
    {
        if(buttonsHandler.conditionToEnd)
        {
            buttonsHandler.canEndMatch = true;

            if (buttonsHandler.matchEnded)
            {
                isRunning = false;
                player1Win = true;
            }

        }
    }

    public void InGame()
    {
        if (!isRunning)
        {
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
        else
        {
            endGameText.gameObject.SetActive(false);
            buttonAgain.gameObject.SetActive(false);
            buttonBackToMenu.gameObject.SetActive(false);
            imageAtEnd.gameObject.SetActive(false);
            buttonResetScore.gameObject.SetActive(false);
            textResetScore.gameObject.SetActive(false);
            textPlayAgain.gameObject.SetActive(false);
            textBackToMenu.gameObject.SetActive(false);
            buttonsHandler.currentPlayerText.gameObject.SetActive(true);
        }
    }
}
