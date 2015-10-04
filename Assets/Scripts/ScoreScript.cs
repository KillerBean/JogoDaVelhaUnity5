using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public Text scoreXText;
	public Text scoreOText;
	public static int scoreXInt = 0;
	public static int scoreOInt = 0;

	// Use this for initialization
	void Start () {
		scoreOText = scoreOText.GetComponent<Text>();
		scoreXText = scoreXText.GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreXText.text = "X : "+scoreXInt;
		scoreOText.text = "O : "+scoreOInt;
	}
}
