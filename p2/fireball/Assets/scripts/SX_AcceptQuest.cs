using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SX_AcceptQuest : MonoBehaviour {
    public Button accept;
    public Canvas letter;
    public GameObject playerPreFab;
    public Canvas pauseMenu;
    public int onOrOff;
    public SX_GameManager manager;
    public enum Pause
    {
        on,
        off,
        endGame
    }
    public Pause pause;

	void Start ()
    {
        letter.enabled = true;
       pause = Pause.on;
	
	}

	void Update ()
    {
        if (pause == Pause.endGame)
        {
            SX_GameManager.playing = false;
        }
        if (pause == Pause.on)
        {
            pauseMenu.enabled = true;
            SX_GameManager.playing = false;
        }
        if (pause == Pause.off)
        {
            pauseMenu.enabled = false;
            SX_GameManager.playing = true;
        }
       
        if (Input.GetButtonDown("Cancel"))
        {
            onOrOff++;
        }
        if (manager.endGame == true)
        {
            pause = Pause.endGame;
            onOrOff = 3;
        }
        if (onOrOff == 2)
        {
            onOrOff = 0;
        }
        if (onOrOff == 0)
        {
            pause = Pause.on;
        }
        if (onOrOff == 1)
        {
            pause = Pause.off;
        }
    }

    public void OnButtonClick()
    {
        letter.enabled = false;
        SX_GameManager.playing = true;
    } 
}
