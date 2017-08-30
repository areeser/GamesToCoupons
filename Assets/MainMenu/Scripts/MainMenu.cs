using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        
        if (GUI.Button(new Rect(Screen.width * 2 / 3 - Screen.width / 2, Screen.height / 24 - Screen.height / 42, Screen.width * 2 / 3, Screen.height / 24), "Picture Roulette"))
        {
            SceneManager.LoadScene("RouletteMenu");
        }
        if (GUI.Button(new Rect(Screen.width * 2 / 3 - Screen.width / 2, Screen.height * 3 / 24 - Screen.height / 42, Screen.width * 2 / 3, Screen.height / 24), "Picture Match"))
        {
            SceneManager.LoadScene("PictureMatchMenu");
        }
        if (GUI.Button(new Rect(Screen.width * 2 / 3 - Screen.width / 2, Screen.height * 5 / 24 - Screen.height / 42, Screen.width * 2 / 3, Screen.height / 24), "Other"))
        {
            SceneManager.LoadScene("");
        }
    }
}
