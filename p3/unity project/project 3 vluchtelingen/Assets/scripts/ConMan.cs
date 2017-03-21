using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConMan : MonoBehaviour {
    public static bool isTalking;
    public Conversation con1;

    void Start () {

	}
	

	void Update () {
		
	}
    public void Choice1()
    {

    }

    public void Choice2()
    {
       
        if (isTalking == false)
        {
            con1.antwoordCount = 1;
            con1.npc = 1;
        }
        con1.NextStage();
    }

    public void Choice3()
    {

    }
}
