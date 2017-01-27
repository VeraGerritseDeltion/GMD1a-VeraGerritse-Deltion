using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SX_Quest : MonoBehaviour {

    public Text amountDummysDead;
    public Text dummysToKill;
    public int dummyDead;
    public SX_SpawnEnemy spawn;
    public bool normalBool;
    public List<bool> quest = new List<bool>();
    public int amountNeeded;
    public int amount = 0;
    public float timer;
    public bool times;
    public SX_Mana manas;
    public bool extraMana;
    


    void Start()
    {
        QuestLevel();
    }
    void Update ()
    {
        Timer();
        dummysToKill.text = amount.ToString();
        amountDummysDead.text = dummyDead.ToString();
         amountNeeded = spawn.amountDummy - 1;
        int d = 0;
        extraMana = false;
        for (d = 0; d < quest.Count; d++)
        {
            if (quest[amountNeeded] == true && times == false)
            {
                times = true;
                timer = 0;
                manas.manaRegen += 0.4f;
                extraMana = true;
            }

            if (quest[amountNeeded] == true && timer >= 3)
            {
                SX_GameManager.enemyLevel += 1;
                spawn.Resetting();
                
                SX_Mana.mana += SX_GameManager.maxMana / 2;
                QuestLevel();
                SX_GameManager.maxMana += 10;
                times = false;
                
            }
        }
	    
	}

    public void DummysDead()
    {
        for (int i = 0; i<quest.Count; i++)
        {
            quest[dummyDead] = true;
        }
        dummyDead += 1;
    }

    public void QuestLevel()
    {
        quest.Clear();
        int i = 0;        
        amount++;
        for (i = 0; i < amount; i++)
        {
            quest.Add(normalBool);
        }
        dummyDead = 0;
    }   
    public void Timer()
    {
        timer = timer + Time.deltaTime;
    }
}
