using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SX_GameManager : MonoBehaviour {

    public static SX_GameManager script;
    public static int enemyLevel;
    public static float maxMana;
    public static bool playing;
    public int maxLvl;
    public Canvas winScreen;
    public bool endGame;
    public Button exit;

    void Start ()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (script == null)
        {
            script = this;
        }
        else if (script != this)
        {
            Destroy(gameObject);
        }
        enemyLevel = 1;
        winScreen.enabled = false;
    }
	
	void Update ()
    {
        if (playing == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (playing == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if(enemyLevel > maxLvl)
        {
            EndGame();
            endGame = true;
        }	
	}

    public void EndGame()
    {
        winScreen.enabled = true;
    }

    public void OnButtonClick()
    {
        Application.Quit();
        print("lol");
    }

}
