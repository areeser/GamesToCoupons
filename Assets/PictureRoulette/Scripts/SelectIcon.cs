using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectIcon : MonoBehaviour {

    public int selectCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        selectCount = Roulette.selectCount;
        GameObject[] targs = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Roulette>().targets;
        GameObject[] sel = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Roulette>().selected;
        Vector3 vect = targs[Roulette.currTargetPic].transform.position;
        sel[selectCount] = Instantiate(gameObject, new Vector3(vect.x, -vect.y, vect.z), Quaternion.identity);
        sel[selectCount].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sel[selectCount].GetComponent<Collider2D>().enabled = false;
        GameObject bg = Instantiate(GameObject.FindGameObjectWithTag("Background"), sel[selectCount].transform.position, Quaternion.identity);
        bg.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        if (gameObject.tag == targs[Roulette.currTargetPic].tag) {
            ++Roulette.correctMatches;
        }
        ++Roulette.currTargetPic;
        ++Roulette.selectCount;
        if (Roulette.selectCount >= 3) {
            Roulette.endOfGame = true;
        }
    }
}
