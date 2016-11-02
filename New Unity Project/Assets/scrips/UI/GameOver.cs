using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public Canvas gameover;
    public Text scor;
    public Text hscor;
    public Button rest;
    public bool resta;

	// Use this for initialization
	void Start () {
        gameover.enabled = false;
        gameover = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("bal1").GetComponent<Bal>().gameover1 == true)
        {
            gameover.enabled = true;
        }
        scor.text = Bal.score.ToString();
        hscor.text = Bal.highscore.ToString();
        if (resta == true)
        {
            gameover.enabled = false;
            gameover = GetComponent<Canvas>();
        }
	}
    public void Restart()
    {
        resta = true;
    }
}
