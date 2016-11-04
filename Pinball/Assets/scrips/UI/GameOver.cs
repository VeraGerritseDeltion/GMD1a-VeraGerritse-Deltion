using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public Canvas gameover;
    public Text scor;
    public Text hscor;
    public Button rest;
    public bool resta;
    public static bool newballs;
    

	// Use this for initialization
	void Start () {
        gameover.enabled = false;
        gameover = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        newballs = false;
       
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
            resta = false;
            newballs = true;
           
        }
	}
    public void Restart()
    {
        resta = true;
    }
}
