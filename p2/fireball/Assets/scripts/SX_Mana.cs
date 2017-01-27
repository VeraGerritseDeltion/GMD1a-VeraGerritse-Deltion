using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SX_Mana : MonoBehaviour {
    public Image manaBar;    
    public static float mana;
    public float manaRegen;
    public Text remainingMana;
    public Text maximaleMana;
    public float manaRound; 

	void Start ()
    {
        SX_GameManager.maxMana = 20;
        mana = SX_GameManager.maxMana;
	}
	
	void Update ()
    {  
        manaRound = Mathf.Round(mana);
        maximaleMana.text = SX_GameManager.maxMana.ToString();
        remainingMana.text = manaRound.ToString();
        if (mana < SX_GameManager.maxMana)
        {
            mana += manaRegen * Time.deltaTime;
        }
        
        
        manaBar.fillAmount = mana / SX_GameManager.maxMana;
	}
}
