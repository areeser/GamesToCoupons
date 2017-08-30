using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roulette : MonoBehaviour {

    //Current Picture you are trying to match with
    public static int currTargetPic = 0;
    public static int correctMatches = 0;
    public static int selectCount = 0;

    //Current picture in the roulette
    public int currPic = 0;

    public GameObject[] icons = new GameObject[6];
    public GameObject[] iconOrder = new GameObject[6];
    public bool[] iconSelected = new bool[6];
    public GameObject[] targets = new GameObject[3];
    public GameObject[] selected = new GameObject[3];
    public Vector3 target1Pos;
    public Vector3 target2Pos;
    public Vector3 target3Pos;

    public GameObject currRoulettePic;

    public float baseTime = 1f;
    public float timer = 0f;

    public static bool endOfGame = false;
    // Use this for initialization
    void Start () {
        currTargetPic = 0;
        correctMatches = 0;
        selectCount = 0;
        endOfGame = false;
        targets[0] = Instantiate(icons[Random.Range(1, 6)], target1Pos, Quaternion.identity);
        targets[1] = Instantiate(icons[Random.Range(1, 6)], target2Pos, Quaternion.identity);
        targets[2] = Instantiate(icons[Random.Range(1, 6)], target3Pos, Quaternion.identity);
        for (int i = 0; i < targets.Length; ++i) {
            GameObject g = Instantiate(GameObject.FindGameObjectWithTag("Background"), targets[i].transform.position, Quaternion.identity);
            g.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            targets[i].GetComponent<Collider2D>().enabled = false;
        }
        targets[0].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        targets[1].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        targets[2].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        

        for (int i = 0; i < icons.Length; ++i) {
            int select = Random.Range(0, iconSelected.Length);
            while (iconSelected[select]) {
                select = Random.Range(0, iconSelected.Length);
            }
            iconOrder[i] = icons[select];
            iconSelected[select] = true;
        }

        currRoulettePic = Instantiate(iconOrder[currPic], Vector3.zero, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= baseTime / (currTargetPic + 1) && currTargetPic < 3) {
            Destroy(currRoulettePic);
            ++currPic;
            if (currPic >= icons.Length) {
                currPic = 0;
            }
            currRoulettePic = Instantiate(iconOrder[currPic], Vector3.zero, Quaternion.identity);
            timer = 0;
        }
	}

    void OnGUI()
    {
        if (endOfGame && GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 6 - Screen.height / 12, Screen.width / 2, Screen.height / 6), "Back to Menu"))
        {
            SceneManager.LoadScene("RouletteMenu");
        }
    }
}
