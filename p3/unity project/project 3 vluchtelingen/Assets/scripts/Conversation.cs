using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour {
    public Text keuze1;
    public Text keuze2;
    public Text keuze3;
    public Text reply;
    public List<string> textNpc = new List<string>();
    public List<string> awnsers = new List<string>();
    public int possibleNpc;
    public int possiblePlayer;
    public string standaart;
    public int antwoordCount;
    public int npc;
    

	void Start () { 
        for (int i = 0;i < possibleNpc; i++)
        {
            textNpc.Add(standaart);
        }
        for (int i = 0;i< possiblePlayer; i++)
        {
            awnsers.Add(standaart);
        }
        awnsers[0] = "continue";
        textNpc[0] = "beginnen?";
        textNpc[1] = "welkom. hoe gaat het er mee";
        awnsers[1] = "goed, met jou?";
        awnsers[2] = "kan beter. Met jou";
        awnsers[3] = "geweldig, maar dan ook echt geweldig. en met jou dan?";
        reply.text = textNpc[npc];
        keuze2.text = awnsers[0];
        
		
	}


	void Update () {
    

		
	}

    public void NextStage()
    {   
        reply.text = textNpc[npc];
        
        keuze1.text = awnsers[antwoordCount];
        antwoordCount++;
        keuze2.text = awnsers[antwoordCount];
        antwoordCount++;
        keuze3.text = awnsers[antwoordCount];
    }

   
}
