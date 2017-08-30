using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI() {
        GUI.Button(new Rect(Screen.width * 2 / 3 - Screen.width / 2, Screen.height / 24 - Screen.height / 42, Screen.width * 2 / 3, Screen.height / 24), "Picture Roulette");
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 6 - Screen.height / 12, Screen.width / 2, Screen.height / 6), "Easy")) {
            SceneManager.LoadScene("RouletteEasy");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height * 3 / 6 - Screen.height / 12, Screen.width / 2, Screen.height / 6), "Medium"))
        {
            SceneManager.LoadScene("RouletteMedium");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height * 5 / 6 - Screen.height / 12, Screen.width / 2, Screen.height / 6), "Hard"))
        {
            SceneManager.LoadScene("RouletteHard");
        }
        if (GUI.Button(new Rect(Screen.width * 2 / 3 - Screen.width / 2, Screen.height * 23 / 24 - Screen.height / 42, Screen.width * 2 / 3, Screen.height / 24), "Main Menu"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
