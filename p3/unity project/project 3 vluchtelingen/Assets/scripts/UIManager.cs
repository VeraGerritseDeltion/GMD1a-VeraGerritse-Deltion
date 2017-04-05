using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public int awnser;
    public Text vraag;
    public Text knop1;
    public Text knop2;
    public ConversationManager conversations;
    public string awnserText;
    public Canvas conversationCanvas;


	void Start () {
		
	}
	
	
	void Update () {
        if(conversations.cons != null)
        {
            conversationCanvas.enabled = true;
        }
        else
        {
            conversationCanvas.enabled = false;
        }

        vraag.text = conversations.vraag;
        knop1.text = conversations.antwoord1;
        knop2.text = conversations.antwoord2;
       
        
    }

    public void Knop1()
    {
         awnser = 1;
         conversations.Awnser(awnser);
    }

    public void Knop2()
    {
         awnser = -1;
         conversations.Awnser(awnser);
    }
}
