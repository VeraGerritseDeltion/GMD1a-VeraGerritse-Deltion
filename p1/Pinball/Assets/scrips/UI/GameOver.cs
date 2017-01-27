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
    public float tijd;
    

	
	void Start () {
        // gameover scherm uit
        gameover.enabled = false;
        gameover = GetComponent<Canvas>();
	}
	
	
	void Update () {

        //score overzicht
        scor.text = Bal.score.ToString();
        hscor.text = Bal.highscore.ToString();
      
        // bool uit
        newballs = false;
       
        // start timer
       
        if (GameObject.Find("bal1").GetComponent<Bal>().gameover1 == true)
        {
            Timers();            
        }
        //na 3 sec game over scherm aan
        if (tijd > 3)
        {
            gameover.enabled = true;
        }
        
        // als op knop is gedrukt game over scherm uit, reset tijd en ballen aanvullen.
        if (resta == true)
        {
            gameover.enabled = false;
            gameover = GetComponent<Canvas>();
            resta = false;
            newballs = true;
            tijd = 0;
           
        }
	}
        // knop voor restart
        public void Restart()
       {
        resta = true;
         }

       // sec timer
      public void Timers()
    {
        tijd = tijd + Time.deltaTime;
    }
}
