﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour {

	void Start(){
		if(ScoreScript.scoreXInt > 0)
			ScoreScript.scoreXInt = 0;

		if(ScoreScript.scoreOInt > 0)
			ScoreScript.scoreOInt = 0;
	}

	public void NewGame(){
        //Application.LoadLevel("Scene");
        SceneManager.LoadScene("Scene");

    }

	public void CloseGame(){
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
